using Decorator.Component;

namespace Decorator.Decorators;

public abstract class FileDecorator : IFile
{
    protected readonly IFile WrappedFile;

    protected FileDecorator(IFile wrappedFile)
    {
        WrappedFile = wrappedFile;
    }

    public virtual async Task WriteFileAsync(string content)
    {
        await WrappedFile.WriteFileAsync(content);
    }

    public virtual async Task<string> ReadFileAsync()
    {
        return await WrappedFile.ReadFileAsync();
    }
}