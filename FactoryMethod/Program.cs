using FactoryMethod;
using FactoryMethod.Creators;

var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

var type = GetFileType();
var persons = GetPersons();

FileCreator creator = type switch
{
    (int) FileType.Json => new JsonFileCreator(path),
    (int) FileType.Xml => new XmlFileCreator(path),
    _ => throw new Exception("Invalid file type.")
};

await creator.GenerateFilesAsync(persons);
Console.WriteLine("Terminated successfully.");

// Complicate logic to chose a file type
int GetFileType()
{
    return new Random().Next(0, 2);
}

Person[] GetPersons()
{
    // Assume that this is a database call
    return new Person[]
    {
        new() {FirstName = "John", LastName = "Doe", Age = 27},
        new() {FirstName = "Mike", LastName = "Connor", Age = 58},
        new() {FirstName = "Anna", LastName = "Parker", Age = 33},
        new() {FirstName = "Sarah", LastName = "Smith", Age = 78}
    };
}