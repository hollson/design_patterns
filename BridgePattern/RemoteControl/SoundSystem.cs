namespace BridgePattern;

/// <summary>音响（具体实现维度）：新增设备零改动遥控器</summary>
public class SoundSystem : IDevice
{
    private int _volume = 50;

    public string Name => "书房音响";
    public bool IsOn { get; private set; }
    public int Volume { get => _volume; set => _volume = Math.Clamp(value, 0, 100); }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("[音响] 功放启动，蓝牙已连接");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("[音响] 功放关闭");
    }
}
