using Microsoft.Data.Sqlite;

namespace Singleton.Singletons;

public static class SqliteConnector
{
    private static SqliteConnection? _connection;

    public static SqliteConnection GetConnection(string connectionString)
    {
        if (_connection is null)
        {
            Console.WriteLine("Initialize new connection...");
            _connection = new SqliteConnection(connectionString);
            return _connection;
        }

        Console.WriteLine("No need to initialize a new connection...");
        return _connection;
    }
}