using SimpleChatApplication.Models;

namespace SimpleChatApplication.Brokers.Storages;

public partial interface IStorageBroker
{
    Task<User> InsertUserAsync(User user);
    Task<List<User>> SelectAllUsersAsync();
    Task<User> SelectUserByIdAsync(int userId);
    Task<User> DeleteUserAsync(int userId);  
}