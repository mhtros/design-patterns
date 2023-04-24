using System.Text;

namespace Decorator.Component;

public class File : IFile
{
    private readonly string _filename;

    public File(string filename)
    {
        _filename = filename;
    }

    public async Task WriteFileAsync(string data)
    {
        await System.IO.File.WriteAllTextAsync(_filename, data);
    }

    public Task<string> ReadFileAsync()
    {
        return System.IO.File.ReadAllTextAsync(_filename, Encoding.UTF8);
    }
}