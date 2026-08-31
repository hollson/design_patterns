namespace ObserverPattern;

/// <summary>
/// 天气数据，包含气压、湿度和温度。
/// </summary>
class Weather(double humd, double pres, double temp)
{
    public double Pressure { get; } = pres;
    public double Humidity { get; } = humd;
    public double Temperature { get; } = temp;
}
