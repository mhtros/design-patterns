using Prototype.Prototypes;

namespace Prototype.Registries;

public class PrototypeRegistry
{
    private readonly Dictionary<string, IPrototype> _prototypes = new();

    public void Add(string key, IPrototype obj)
    {
        _prototypes.Add(key, obj);
    }

    public void Remove(string key)
    {
        _prototypes.Remove(key);
    }

    public T GetClone<T>(string key) where T : IPrototype
    {
        var instance = _prototypes[key];
        return (T) instance.Clone();
    }
}