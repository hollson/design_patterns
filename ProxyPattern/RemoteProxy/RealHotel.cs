namespace ProxyPattern;

/// <summary>
/// 真实酒店，位于远端，预订需经过网络（用 Thread.Sleep 模拟网络往返）。
/// </summary>
public class RealHotel : IHotel
{
    public void Book(string room)
    {
        Console.WriteLine("正在联系远程酒店服务器...");
        Thread.Sleep(300); // 模拟网络延迟
        Console.WriteLine("预订成功: " + room);
    }
}