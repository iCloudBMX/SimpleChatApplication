using System.Data.SqlClient;

namespace SimpleChatApplication.Brokers.Storages;

public partial class StorageBroker : IStorageBroker
{
    public SqlConnection GetConnection()
    {
        string connectionString = @"Server=(localdb)\mssqllocaldb; Database=Messanger";

        return new SqlConnection(connectionString);
    }
}