using Singleton.Models;
using Singleton.Services;
using Singleton.Singletons;

const string connectionString = "Data Source=usersdb.sqlite;";
const string sql = @"SELECT id, name, age FROM users WHERE id = $id";

using var conn1 = SqliteConnector.GetConnection(connectionString);
var params1 = new Dictionary<string, object> {{"$id", 1}};
var user1 = SqliteQuery.Execute<User>(conn1, sql, params1);
Console.WriteLine($"{user1.Id}. {user1.Name} (age {user1.Age})");

// There will be no new db connection instantiation
using var connection2 = SqliteConnector.GetConnection(connectionString);
var params2 = new Dictionary<string, object> {{"$id", 2}};
var user2 = SqliteQuery.Execute<User>(connection2, sql, params2);
Console.WriteLine($"{user2.Id}. {user2.Name} (age {user2.Age})");