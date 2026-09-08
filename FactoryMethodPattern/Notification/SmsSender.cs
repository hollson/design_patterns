namespace FactoryMethodPattern;

/// <summary>短信发送器（具体产品）</summary>
public class SmsSender : IMessageSender
{
    public string Channel => "短信";

    public void Send(string to, string content) =>
        Console.WriteLine($"[发送] 向 {to} 发送短信：{content}");
}
