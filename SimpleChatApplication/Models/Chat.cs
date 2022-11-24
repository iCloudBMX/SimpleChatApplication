namespace SimpleChatApplication.Models;

public class Chat
{
    public int ID { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Type { get; set; }

    public Chat(DateTime createdAt, int type)
    {
        CreatedAt = createdAt;
        Type = type;
    }
}