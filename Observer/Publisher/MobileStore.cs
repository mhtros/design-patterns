using Observer.Models;

namespace Observer.Publisher;

public class MobileStore : IObservable<Mobile>
{
    private readonly List<IObserver<Mobile>> _subscribers = new();

    public IDisposable Subscribe(IObserver<Mobile> subscriber)
    {
        if (!_subscribers.Contains(subscriber)) _subscribers.Add(subscriber);
        return new UnSubscriber(_subscribers, subscriber);
    }

    public void NewMobileRelease(Mobile? mobile)
    {
        foreach (var subscriber in _subscribers)
            if (mobile == null)
                subscriber.OnError(new ArgumentNullException(nameof(mobile)));
            else
                subscriber.OnNext(mobile);
    }

    public void Bankruptcy()
    {
        foreach (var subscriber in _subscribers)
            if (_subscribers.Contains(subscriber))
                subscriber.OnCompleted();

        _subscribers.Clear();
    }

    private class UnSubscriber : IDisposable
    {
        private readonly IObserver<Mobile>? _subscriber;
        private readonly List<IObserver<Mobile>>? _subscribers;

        public UnSubscriber(List<IObserver<Mobile>> subscribers, IObserver<Mobile> subscriber)
        {
            _subscribers = subscribers;
            _subscriber = subscriber;
        }

        public void Dispose()
        {
            if (_subscriber != null && _subscribers != null && _subscribers.Contains(_subscriber))
                _subscribers.Remove(_subscriber);
        }
    }
}