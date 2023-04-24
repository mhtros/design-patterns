namespace Decorator.Component;

public interface IFile
{
    public Task WriteFileAsync(string content);

    public Task<string> ReadFileAsync();
}