using System.Data;

namespace Singleton.Models;

public class User : IDbPopulteable
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Populate(IDataReader reader)
    {
        while (reader.Read())
        {
            Id = reader.GetInt32(0);
            Name = reader.GetString(1);
            Age = reader.GetInt32(2);
        }
    }
}