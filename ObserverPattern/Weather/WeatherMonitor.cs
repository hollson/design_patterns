namespace ObserverPattern.Weather;

/// <summary>
/// 天气显示器——订阅天气数据并展示
/// </summary>
sealed class WeatherMonitor : IObserver<Weather>
{
    private IDisposable _cancellation = null!;
    private readonly string _name;

    public WeatherMonitor(string name) => _name = name;

    public void Subscribe(WeatherSupplier supplier) =>
        _cancellation = supplier.Subscribe(this);

    public void Unsubscribe() => _cancellation.Dispose();

    public void OnNext(Weather value) =>
        Console.WriteLine($"{_name}: 温度 {value.Temperature}°C, " +
                          $"气压 {value.Pressure} 大气压, 湿度 {value.Humidity * 100:F0}%");

    public void OnError(Exception error) =>
        Console.WriteLine($"{_name} 发生错误: {error.Message}");

    public void OnCompleted() { }
}