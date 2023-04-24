namespace Decorator.Common;

public interface ITextCryptography
{
    public string EncryptText(string text);

    public string DecryptText(string encryptedText);
}