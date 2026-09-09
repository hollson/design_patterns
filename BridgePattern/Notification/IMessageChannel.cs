namespace BridgePattern;

/// <summary>发送渠道（实现维度）：真正把消息送出去的通道，可独立新增</summary>
public interface IMessageChannel
{
    string ChannelName { get; }                     // 渠道名

    void Send(string to, string content);           // 发送消息
}
