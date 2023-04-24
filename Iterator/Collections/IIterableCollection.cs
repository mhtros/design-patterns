using Iterator.Iterators;

namespace Iterator.Collections;

public interface IIterableCollection<T>
{
    public int Length { get; }
    public IIterator<T> CreateIterator<TIterator>() where TIterator : IIterator<T>;
    public T GetItem(int index);
}