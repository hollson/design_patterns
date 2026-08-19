namespace ObserverPattern;

/// <summary>
/// 天气数据，包含气压、湿度和温度。
/// </summary>
class Weather
{
    public double Pressure { get; }
    public double Humidity { get; }
    public double Temperature { get; }

    public Weather(double humd, double pres, double temp)
    {
        Temperature = temp;
        Pressure = pres;
        Humidity = humd;
    }
}
