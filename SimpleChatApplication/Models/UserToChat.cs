namespace SimpleChatApplication.Models;

public class UserToChat
{
    public int ChatID { get; set; }
    public int UserID { get; set; }

    public UserToChat(int chatID, int userID)
    {
        ChatID = chatID;
        UserID = userID;
    }
}
