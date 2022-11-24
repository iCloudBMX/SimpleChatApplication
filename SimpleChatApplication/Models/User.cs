namespace SimpleChatApplication.Models;

public class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int? Status { get; set; }
    public string? PhoneNumber { get; set; }
    public bool IsBot { get; set; }

    public User(int id, string name, int? status, string? phoneNumber, bool isBot)
    {
        ID = id;
        Name = name;
        Status = status;
        PhoneNumber = phoneNumber;
        IsBot = isBot;
    }

    public User(string name, int? status, string? phoneNumber, bool isBot)
    {
        Name = name;
        Status = status;
        PhoneNumber = phoneNumber;
        IsBot = isBot;
    }
}
