namespace ObserverPattern.News;

/// <summary>
/// 退订句柄——从观察者列表中移除指定观察者
/// </summary>
internal class Unsubscriber<T> : IDisposable
{
    private readonly List<IObserver<T>> _observers;
    private readonly IObserver<T> _observer;

    internal Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
    {
        _observers = observers;
        _observer = observer;
    }

    public void Dispose()
    {
        if (_observers.Contains(_observer))
            _observers.Remove(_observer);
    }
}