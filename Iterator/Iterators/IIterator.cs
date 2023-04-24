namespace Iterator.Iterators;

public interface IIterator<out T>
{
    public T? Next();
    public bool HasMore();
    public void Reset();
}