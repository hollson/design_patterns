namespace BridgePattern;

/// <summary>遥控器（抽象维度）：持有设备引用，只做通用控制，不关心具体家电</summary>
public class RemoteControl(IDevice device)
{
    protected IDevice Device { get; } = device;        // 桥：组合代替继承

    /// <summary>电源开关</summary>
    public void TogglePower()
    {
        Console.WriteLine($">> 按下【电源】键");
        if (Device.IsOn) Device.TurnOff();
        else Device.TurnOn();
    }

    /// <summary>音量 +10</summary>
    public void VolumeUp()
    {
        Console.WriteLine($">> 按下【音量+】键");
        Device.Volume += 10;
        Console.WriteLine($"[遥控] {Device.Name} 音量 → {Device.Volume}");
    }

    /// <summary>音量 -10</summary>
    public void VolumeDown()
    {
        Console.WriteLine($">> 按下【音量-】键");
        Device.Volume -= 10;
        Console.WriteLine($"[遥控] {Device.Name} 音量 → {Device.Volume}");
    }
}
