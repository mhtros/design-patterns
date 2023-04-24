using Decorator.Common;
using Decorator.Component;

namespace Decorator.Decorators;

public class EncryptedFileDecorator : FileDecorator
{
    private readonly ITextCryptography _textCryptography;

    public EncryptedFileDecorator(IFile wrappedFile, ITextCryptography textCryptography) : base(wrappedFile)
    {
        _textCryptography = textCryptography;
    }

    public override Task WriteFileAsync(string content)
    {
        var encrypted = _textCryptography.EncryptText(content);
        return WrappedFile.WriteFileAsync(encrypted);
    }

    public override async Task<string> ReadFileAsync()
    {
        var encrypted = await WrappedFile.ReadFileAsync();
        var decrypted = _textCryptography.DecryptText(encrypted);
        return decrypted;
    }
}