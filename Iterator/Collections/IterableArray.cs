using Iterator.Iterators;

namespace Iterator.Collections;

public class IterableArray<T> : IIterableCollection<T>
{
    private readonly T[] _internalArray;

    public IterableArray(params T[] items)
    {
        Length = items.Length;
        _internalArray = new T[Length];
        Array.Copy(items, _internalArray, Length);
    }

    public int Length { get; }

    public IIterator<T> CreateIterator<TIterator>() where TIterator : IIterator<T>
    {
        if (!typeof(TIterator).GetInterfaces().Contains(typeof(IIterator<T>)))
        {
            var msg = $"Iterator type {typeof(TIterator)} not compatible with type {typeof(IIterator<T>)}";
            throw new TypeLoadException(msg);
        }

        var instance = Activator.CreateInstance(typeof(TIterator), this);
        if (instance is null) throw new NullReferenceException();
        return (IIterator<T>) instance;
    }

    public T GetItem(int index)
    {
        return _internalArray[index];
    }
}