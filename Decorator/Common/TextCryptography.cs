using System.Security.Cryptography;
using System.Text;

namespace Decorator.Common;

public sealed class TextCryptography : ITextCryptography, IDisposable
{
    private readonly Aes _aes;

    public TextCryptography(string key)
    {
        _aes = Aes.Create();
        _aes.Key = Encoding.UTF8.GetBytes(key);
        _aes.IV = new byte[16];
    }

    public void Dispose()
    {
        _aes.Dispose();
    }

    public string EncryptText(string text)
    {
        byte[] array;
        var encryptor = _aes.CreateEncryptor(_aes.Key, _aes.IV);

        using (var memoryStream = new MemoryStream())
        {
            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
            {
                using (var streamWriter = new StreamWriter(cryptoStream))
                {
                    streamWriter.Write(text);
                }

                array = memoryStream.ToArray();
            }
        }

        return Convert.ToBase64String(array);
    }

    public string DecryptText(string encryptedText)
    {
        var buffer = Convert.FromBase64String(encryptedText);
        var decrypted = _aes.CreateDecryptor(_aes.Key, _aes.IV);

        using var memoryStream = new MemoryStream(buffer);
        using var cryptoStream = new CryptoStream(memoryStream, decrypted, CryptoStreamMode.Read);
        using var streamReader = new StreamReader(cryptoStream);

        return streamReader.ReadToEnd();
    }
}