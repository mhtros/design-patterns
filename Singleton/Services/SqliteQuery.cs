using Microsoft.Data.Sqlite;
using Singleton.Models;

namespace Singleton.Services;

public static class SqliteQuery
{
    public static TEntity Execute<TEntity>(SqliteConnection connection, string query,
        Dictionary<string, object> parameters) where TEntity : IDbPopulteable, new()
    {
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = query;

        foreach (var parameter in parameters) command.Parameters.AddWithValue(parameter.Key, parameter.Value);

        using var reader = command.ExecuteReader();

        var entity = new TEntity();
        entity.Populate(reader);
        return entity;
    }
}