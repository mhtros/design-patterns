using System.Data;

namespace Singleton.Models;

public interface IDbPopulteable
{
    public void Populate(IDataReader reader);
}