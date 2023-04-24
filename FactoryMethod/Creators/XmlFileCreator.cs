using FactoryMethod.Products;

namespace FactoryMethod.Creators;

public class XmlFileCreator : FileCreator
{
    public XmlFileCreator(string path) : base(path, "xml")
    {
    }

    protected override ISerializer CreateSerializer()
    {
        return new XmlSerializer();
    }
}