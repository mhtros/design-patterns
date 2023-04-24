namespace FactoryMethod.Products;

public class XmlSerializer : ISerializer
{
    public string Serialize<T>(T obj)
    {
        // Assume that this is a custom implementation.
        var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
        using var textWriter = new StringWriter();
        xmlSerializer.Serialize(textWriter, obj);
        return textWriter.ToString();
    }
}