namespace FactoryMethod.Products;

public class JsonSerializer : ISerializer
{
    public string Serialize<T>(T obj)
    {
        // Assume that this is a custom implementation. 
        return System.Text.Json.JsonSerializer.Serialize(obj);
    }
}