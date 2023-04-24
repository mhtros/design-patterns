using Decorator.Common;
using Decorator.Decorators;
using File = Decorator.Component.File;

var filename = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\content.txt";
var file = new File(filename);

var textCryptography = new TextCryptography("b14ca5898a4e4133bbce2ea2315a1916");
var encryptDecorator = new EncryptedFileDecorator(file, textCryptography);

var textCompressor = new TextCompressor();
// We stack compressor decorator on top of encryption decorator
var combinedDecorator = new CompressorFileDecorator(encryptDecorator, textCompressor);

await combinedDecorator.WriteFileAsync("Hello world!");
var text = await combinedDecorator.ReadFileAsync();

Console.WriteLine(text);