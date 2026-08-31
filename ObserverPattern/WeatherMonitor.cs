namespace ObserverPattern;

/// <summary>
/// 气象站，作为观察者订阅天气供应者并根据名称显示对应的天气指标。
/// </summary>
sealed class WeatherMonitor : IObserver<Weather>
{
    private IDisposable _cancellation = null!;
    private readonly string _name;

    public WeatherMonitor(string name)
    {
        _name = name;
    }

    public void Subscribe(WeatherSupplier provider)
    {
        _cancellation = provider.Subscribe(this);
    }

    public void Unsubscribe() => _cancellation.Dispose();

    public void OnCompleted() => throw new NotImplementedException();

    public void OnError(Exception error) => Console.WriteLine("Error has occured");

    public void OnNext(Weather value)
    {
        Console.WriteLine(_name);
        if (_name.Contains("T"))
        {
            string op = $"| 温度: {value.Temperature} 摄氏度 |";
            Console.Write(op);
        }
        if (_name.Contains("P"))
        {
            string op = $"| 气压: {value.Pressure} 大气压 |";
            Console.Write(op);
        }
        if (_name.Contains("H"))
        {
            string op = $"| 湿度: {value.Humidity * 100} % |";
            Console.Write(op);
        }
        if (!(_name.Contains("T") || _name.Contains("P") || _name.Contains("H")))
        {
            OnError(new Exception());
        }
        Console.WriteLine();
    }
}
