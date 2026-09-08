namespace FactoryMethodPattern;

/// <summary>消息发送器（产品）：真正把消息发出去的通道</summary>
public interface IMessageSender
{
    string Channel { get; }                  // 渠道名

    void Send(string to, string content);    // 发送消息
}
