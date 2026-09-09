namespace BridgePattern;

/// <summary>邮件渠道（具体实现维度）</summary>
public class EmailChannel : IMessageChannel
{
    public string ChannelName => "邮件";

    public void Send(string to, string content) =>
        Console.WriteLine($"[邮件] 已发送至 {to}：{content}");
}
