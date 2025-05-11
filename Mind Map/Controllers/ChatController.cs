using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ChatBotApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly ILogger<ChatController> _logger;

        public ChatController(
            IHttpClientFactory httpClientFactory,
            AppDbContext context,
            IConfiguration configuration,
            ILogger<ChatController> logger)
        {
            _httpClientFactory = httpClientFactory;
            _context = context;
            _configuration = configuration;
            _logger = logger;
        }

        [HttpPost]
        [HttpPost]
        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody] ChatRequest request)
        {
            try
            {
                // Get chatbot service URL from configuration

                string chatbotUrl = _configuration["JWT:ChatbotService:Url"];  // Make sure path matches your config
                _logger.LogInformation($"Connecting to chatbot URL: {chatbotUrl}");

                int timeout = _configuration.GetValue<int>("JWT:ChatbotService:Timeout", 60);
                var client = _httpClientFactory.CreateClient();
                client.Timeout = TimeSpan.FromSeconds(timeout);

                // Log the request 
                var requestData = new { message = request.UserMessage };
                _logger.LogInformation($"Sending request to chatbot: {JsonSerializer.Serialize(requestData)}");

                // Simplified request - only send the user message
                var jsonContent = new StringContent(
                    JsonSerializer.Serialize(requestData),
                    Encoding.UTF8,
                    "application/json");

                var response = await client.PostAsync(chatbotUrl, jsonContent);
                _logger.LogInformation($"Response status code: {(int)response.StatusCode}");

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Error response from chatbot: {errorContent}");
                    return StatusCode((int)response.StatusCode, "حدث خطأ أثناء التواصل مع الشات بوت.");
                }

                var responseString = await response.Content.ReadAsStringAsync();
                _logger.LogInformation($"Response received: {responseString}");

                var responseData = JsonSerializer.Deserialize<Dictionary<string, string>>(
                    responseString,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                var botResponse = responseData["response"];

                // Save conversation to database
                var conversation = new UserChatBotHistory
                {
                    UserId = request.UserId,
                    UserMessage = request.UserMessage,
                    BotResponse = botResponse,
                    CreatedAt = DateTime.UtcNow
                };
                _context.UserChatBotHistories.Add(conversation);
                await _context.SaveChangesAsync();

                // Return just the bot response text
                return Ok(new { botResponse });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in chatbot request: {ex.Message}");
                if (ex.InnerException != null)
                    _logger.LogError($"Inner exception: {ex.InnerException.Message}");
                _logger.LogError($"Stack trace: {ex.StackTrace}");
                return StatusCode(500, "حدث خطأ غير متوقع.");
            }
        }


        [HttpGet("test")]
        public async Task<IActionResult> TestChatbotConnection()
        {
            try
            {
                // Get the same URL you use for the chatbot
                string chatbotUrl = _configuration["JWT:ChatbotService:Url"];
                _logger.LogInformation($"Testing connection to: {chatbotUrl}");

                var client = _httpClientFactory.CreateClient();

                // Try first the /health endpoint
                string healthUrl = chatbotUrl.Replace("/chat", "/health");
                _logger.LogInformation($"Testing health endpoint: {healthUrl}");

                try
                {
                    var healthResponse = await client.GetAsync(healthUrl);
                    var healthContent = await healthResponse.Content.ReadAsStringAsync();

                    if (healthResponse.IsSuccessStatusCode)
                    {
                        _logger.LogInformation("Health check succeeded");
                        return Ok(new
                        {
                            Status = "Success",
                            HealthEndpoint = healthUrl,
                            StatusCode = (int)healthResponse.StatusCode,
                            Response = healthContent
                        });
                    }
                }
                catch (Exception healthEx)
                {
                    _logger.LogError($"Health check failed: {healthEx.Message}");
                }

                // If health check fails, try a simple POST to the chat endpoint
                var testRequest = new { message = "test" };
                var jsonContent = new StringContent(
                    JsonSerializer.Serialize(testRequest),
                    Encoding.UTF8,
                    "application/json");

                var response = await client.PostAsync(chatbotUrl, jsonContent);
                var content = await response.Content.ReadAsStringAsync();

                return Ok(new
                {
                    Status = response.IsSuccessStatusCode ? "Success" : "Failed",
                    ChatEndpoint = chatbotUrl,
                    StatusCode = (int)response.StatusCode,
                    Response = content
                });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Connection test failed: {ex.Message}");
                if (ex.InnerException != null)
                    _logger.LogError($"Inner exception: {ex.InnerException.Message}");

                return StatusCode(500, new
                {
                    Status = "Error",
                    Error = ex.Message,
                    StackTrace = ex.StackTrace
                });
            }
        }
        [HttpGet("history/{userId}")]
        public async Task<IActionResult> GetUserHistory(int userId, [FromQuery] int limit = 10)
        {
            try
            {
                var history = await _context.UserChatBotHistories
                    .Where(h => h.UserId == userId)
                    .OrderByDescending(h => h.CreatedAt)
                    .Take(limit)
                    .ToListAsync();

                return Ok(history);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving chat history: {ex.Message}");
                return StatusCode(500, "حدث خطأ أثناء استرجاع سجل المحادثات.");
            }
        }
    }
}

