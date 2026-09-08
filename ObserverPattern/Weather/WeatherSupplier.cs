namespace ObserverPattern.Weather;

/// <summary>
/// 气象站——维护观察者列表，状态变化时推送通知
/// </summary>
class WeatherSupplier : IObservable<Weather>
{
    private readonly List<IObserver<Weather>> _observers = [];

    public IDisposable Subscribe(IObserver<Weather> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
        return new Unsubscriber<Weather>(_observers, observer);
    }

    /// <summary>
    /// 产生新天气数据，通知所有观察者
    /// </summary>
    public void WeatherConditions(double temp, double pressure, double humidity)
    {
        var weather = new Weather(temp, pressure, humidity);
        foreach (var observer in _observers)
            observer.OnNext(weather);
    }
}