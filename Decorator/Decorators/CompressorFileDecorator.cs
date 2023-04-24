using Decorator.Common;
using Decorator.Component;

namespace Decorator.Decorators;

public class CompressorFileDecorator : FileDecorator
{
    private readonly ITextCompressor _textCompressor;

    public CompressorFileDecorator(IFile wrappedFile, ITextCompressor textCompressor) : base(wrappedFile)
    {
        _textCompressor = textCompressor;
    }

    public override Task WriteFileAsync(string content)
    {
        var compressed = _textCompressor.CompressText(content);
        return WrappedFile.WriteFileAsync(compressed);
    }

    public override async Task<string> ReadFileAsync()
    {
        var compressed = await WrappedFile.ReadFileAsync();
        var decompressed = _textCompressor.DecompressText(compressed);
        return decompressed;
    }
}