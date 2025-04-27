namespace Mind_Map.Models.ChatBot
{
    public class UserChatBotHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserMessage { get; set; }
        public string BotResponse { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
