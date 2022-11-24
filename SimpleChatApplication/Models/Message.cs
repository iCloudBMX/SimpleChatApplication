namespace SimpleChatApplication.Models;

public class Message
{
    public int ID { get; set; }
    public int ChatID { get; set; }
    public DateTime CreatedAt { get; set; }
    public int FromID { get; set; }

    public Message( int chatID, DateTime createdAt, int fromID)
    {
        ChatID = chatID;
        CreatedAt = createdAt;
        FromID = fromID;
    }
}
