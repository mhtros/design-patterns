using Prototype.Prototypes;
using Prototype.Registries;

var student = new Student
{
    StudentCode = Guid.NewGuid(),
    Name = "John",
    Age = 33,
    Address = new Address
    {
        District = "Old Cey",
        Number = "420",
        Street = "Blue Raspberry",
        PostCode = "1938 95"
    }
};

var address = new Address
{
    District = "Tweak",
    Number = "69",
    Street = "Chapel street",
    PostCode = "5233 19"
};

var person = new Person
{
    Name = "Michael",
    Age = 12
};

var clone = (Student) student.Clone();
student.Age = 88;

var registry = new PrototypeRegistry();
registry.Add("a", address);
registry.Add("p", person);

var cloneAddress = registry.GetClone<Address>("a");
cloneAddress.Number = "123";

Console.WriteLine(address);
Console.WriteLine(cloneAddress);

Console.WriteLine(student);
Console.WriteLine(clone);