namespace BridgePattern;

/// <summary>短信渠道（具体实现维度）：新增渠道零改动通知类型</summary>
public class SmsChannel : IMessageChannel
{
    public string ChannelName => "短信";

    public void Send(string to, string content) =>
        Console.WriteLine($"[短信] 已发送至 {to}：{content}");
}
