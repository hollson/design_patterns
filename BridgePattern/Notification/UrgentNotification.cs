namespace BridgePattern;

/// <summary>加急通知（扩展抽象维度）：所有渠道连续发 2 遍 + 拨打电话提醒</summary>
public class UrgentNotification(IMessageChannel channel) : Notification(channel)
{
    public void NotifyUrgent(string to, string content)
    {
        Console.WriteLine($"[通知] 加急！通过{Channel.ChannelName}连续发送 2 遍并电话提醒");
        Channel.Send(to, $"【加急】{content}");
        Channel.Send(to, $"【加急】{content}");
        Console.WriteLine($"[电话] 已拨打 {to}，请立即查看{Channel.ChannelName}");
    }
}
