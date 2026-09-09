namespace AdapterPattern;

/// <summary>英标设备（被适配者）：接口与国标完全不兼容</summary>
public class BritishPlug(string device)
{
    /// <summary>英标三脚插头连接——方法名、形状都是英式标准</summary>
    public void ThreePinConnect() =>
        Console.WriteLine($"[供电] 英标三脚插头已连接，220V 供电成功，{device}开始工作");
}
