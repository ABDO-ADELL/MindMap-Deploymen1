
namespace ChatBotApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppDbContext _context;

        public ChatController(IHttpClientFactory httpClientFactory, AppDbContext context)
        {
            _httpClientFactory = httpClientFactory;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody] ChatRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            var url = "http://localhost:5000/chat";

            var jsonContent = new StringContent(JsonSerializer.Serialize(new { message = request.UserMessage }), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, jsonContent);

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode(500, "حدث خطأ أثناء التواصل مع الشات بوت.");
            }

            var responseString = await response.Content.ReadAsStringAsync();
            var responseData = JsonSerializer.Deserialize<Dictionary<string, string>>(responseString);

            var botResponse = responseData["response"];

            var conversation = new UserChatBotHistory
            {
                UserId = request.UserId,
                UserMessage = request.UserMessage,
                BotResponse = botResponse,
                CreatedAt = DateTime.Now
            };

            _context.UserChatBotHistories.Add(conversation);
            await _context.SaveChangesAsync();

            return Ok(new { botResponse });
        }
    }

}
