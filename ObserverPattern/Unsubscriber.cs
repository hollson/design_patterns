namespace ObserverPattern;

/// <summary>
/// 取消订阅辅助类，实现 IDisposable 以从观察者列表中移除指定观察者。
/// </summary>
internal class Unsubscriber<TWeather> : IDisposable
{
    private readonly List<IObserver<TWeather>> _observers;
    private readonly IObserver<TWeather> _observer;

    internal Unsubscriber(List<IObserver<TWeather>> observers, IObserver<TWeather> observer)
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
