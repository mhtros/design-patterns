using System.Text.Json;

namespace Prototype.Prototypes;

public class Person : IPrototype
{
    public Person()
    {
    }

    protected Person(Person source)
    {
        Name = source.Name;
        Age = source.Age;
        Address = (Address?) source.Address?.Clone() ?? new Address();
    }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public Address? Address { get; set; }

    public virtual object Clone()
    {
        return new Person(this);
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}