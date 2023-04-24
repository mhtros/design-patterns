using FactoryMethod.Products;

namespace FactoryMethod.Creators;

public class JsonFileCreator : FileCreator
{
    public JsonFileCreator(string path) : base(path, "json")
    {
    }

    protected override ISerializer CreateSerializer()
    {
        return new JsonSerializer();
    }
}