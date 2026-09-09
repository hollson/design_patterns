namespace BridgePattern;

/// <summary>电视机（具体实现维度）</summary>
public class Tv : IDevice
{
    private int _volume = 30;

    public string Name => "客厅电视";
    public bool IsOn { get; private set; }
    public int Volume { get => _volume; set => _volume = Math.Clamp(value, 0, 100); }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("[电视] 屏幕点亮，欢迎回来");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("[电视] 屏幕熄灭，进入待机");
    }
}
