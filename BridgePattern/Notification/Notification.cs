namespace BridgePattern;

/// <summary>通知（抽象维度）：持有渠道引用，控制"怎么发"，不关心"从哪发"</summary>
public class Notification(IMessageChannel channel)
{
    protected IMessageChannel Channel { get; } = channel;      // 桥：组合代替继承

    /// <summary>普通通知：直接发送</summary>
    public void Notify(string to, string content)
    {
        Console.WriteLine($"[通知] 通过{Channel.ChannelName}发送普通通知");
        Channel.Send(to, content);
    }
}
