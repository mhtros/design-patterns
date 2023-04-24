using System.Text.Json;

namespace Prototype.Prototypes;

public class Address : IPrototype
{
    public Address()
    {
    }

    private Address(Address source)
    {
        Street = source.Street;
        PostCode = source.PostCode;
        District = source.District;
        Number = source.Number;
    }

    public string? Street { get; set; }
    public string? PostCode { get; set; }
    public string? District { get; set; }
    public string? Number { get; set; }

    public object Clone()
    {
        return new Address(this);
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}