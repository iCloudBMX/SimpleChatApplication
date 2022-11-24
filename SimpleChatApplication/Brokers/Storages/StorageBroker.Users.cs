using SimpleChatApplication.Brokers.Storages.Helper;
using SimpleChatApplication.Models;
using System.Data;
using System.Data.SqlClient;

namespace SimpleChatApplication.Brokers.Storages;

public partial class StorageBroker : IStorageBroker
{
    public async Task<User> InsertUserAsync(User user)
    {
        using var connection = GetConnection();
        using var command = connection.CreateCommand();
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = StoragerBrokerHelper.SP_InsertUser;
        command.Parameters.Add(new SqlParameter("@Name", user.Name));
        command.Parameters.Add(new SqlParameter("@IsBot", user.IsBot));

        await connection.OpenAsync();
        using var dataReader = await command.ExecuteReaderAsync();

        var users = await ParseDataFromDataReader(dataReader);

        return users.FirstOrDefault();
    }

    public async Task<List<User>> SelectAllUsersAsync()
    {
        using var connection = GetConnection();
        using var command = connection.CreateCommand();
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = StoragerBrokerHelper.SP_SelectAllUsers;

        await connection.OpenAsync();
        using var dataReader = await command.ExecuteReaderAsync();

        return await ParseDataFromDataReader(dataReader);
    }

    public Task<User> SelectUserByIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<User> DeleteUserAsync(int userId)
    {
        throw new NotImplementedException();
    }
    
    private async Task<List<User>> ParseDataFromDataReader(SqlDataReader dataReader)
    {
        List<User> users = new List<User>();

        while(await dataReader.ReadAsync())
        {
            var user = new User(
                id: dataReader.GetInt32(0),
                name: dataReader.GetString(1),
                null,
                null,
                true);

            users.Add(user);
        }

        return users;
    }
}