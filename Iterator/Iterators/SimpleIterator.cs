using Iterator.Collections;

namespace Iterator.Iterators;

public class SimpleIterator<T> : IIterator<T>
{
    private readonly IIterableCollection<T?> _collection;
    private int _current = -1;

    public SimpleIterator(IIterableCollection<T?> collection)
    {
        _collection = collection;
    }

    public T? Next()
    {
        if (!HasMore()) return default;

        _current++;
        return _collection.GetItem(_current);
    }

    public bool HasMore()
    {
        return _current < _collection.Length - 1;
    }

    public void Reset()
    {
        _current = -1;
    }
}