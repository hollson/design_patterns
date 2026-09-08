namespace FactoryMethodPattern;

/// <summary>邮件发送器（具体产品）</summary>
public class EmailSender : IMessageSender
{
    public string Channel => "邮件";

    public void Send(string to, string content) =>
        Console.WriteLine($"[发送] 向 {to} 发送邮件：{content}");
}
