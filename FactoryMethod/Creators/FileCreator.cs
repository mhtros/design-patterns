using System.Text;
using FactoryMethod.Products;

namespace FactoryMethod.Creators;

public abstract class FileCreator
{
    private readonly string _filePrefix;
    private readonly string _path;

    protected FileCreator(string path, string filePrefix)
    {
        _path = path;
        _filePrefix = filePrefix;
    }

    // We leave it virtual just in case some subclass want to override it.
    public virtual async Task GenerateFilesAsync<T>(IList<T> objects)
    {
        var basePath = $"{_path}\\GeneratedFiles_{DateTime.Now:yyyyMMdd}";
        if (!Directory.Exists(basePath)) Directory.CreateDirectory(basePath);

        var serializer = CreateSerializer();

        for (var i = 0; i < objects.Count; i++)
        {
            var file = $"{basePath}\\file{i + 1}.{_filePrefix}";
            var serialized = serializer.Serialize(objects.ElementAt(i));
            await File.WriteAllTextAsync(file, serialized, Encoding.UTF8);
        }
    }

    protected abstract ISerializer CreateSerializer();
}