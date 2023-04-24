namespace Decorator.Common;

public interface ITextCompressor
{
    public string CompressText(string text);

    public string DecompressText(string text);
}