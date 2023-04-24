using Observer.Models;

namespace Observer.Subscribers;

public abstract class MobileBuyer : IObserver<Mobile>
{
    private IDisposable? _unsubscriber;

    public virtual void OnError(Exception error)
    {
        Console.WriteLine(error.Message);
    }

    public virtual void OnCompleted()
    {
        Console.WriteLine($"{nameof(OnCompleted)} has been called.");
    }

    public abstract void OnNext(Mobile mobile);

    public virtual void Subscribe(IObservable<Mobile>? publisher)
    {
        if (publisher != null)
            _unsubscriber = publisher.Subscribe(this);
    }

    public virtual void Unsubscribe()
    {
        _unsubscriber?.Dispose();
    }
}