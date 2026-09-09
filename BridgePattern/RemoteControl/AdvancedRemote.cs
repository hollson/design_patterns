namespace BridgePattern;

/// <summary>高级遥控器（扩展抽象维度）：新增按键零改动设备</summary>
public class AdvancedRemote(IDevice device) : RemoteControl(device)
{
    /// <summary>静音键：高级遥控器独有</summary>
    public void Mute()
    {
        Console.WriteLine($">> 按下【静音】键");
        Device.Volume = 0;
        Console.WriteLine($"[遥控] {Device.Name} 已静音");
    }
}
