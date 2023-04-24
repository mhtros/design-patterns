namespace FactoryMethod.Products;

public interface ISerializer
{
    public string Serialize<T>(T obj);
}