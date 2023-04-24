using Memento.Mementos;

namespace Memento.Originators;

public interface ISnapshot<T> where T : StateSnapshot
{
    public T CreateSnapshot();

    public void RestoreFromSnapshot(T state);
}