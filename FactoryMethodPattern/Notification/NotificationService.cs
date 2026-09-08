namespace FactoryMethodPattern;

/// <summary>通知服务（抽象创建者）：固化「创建发送器 → 发送」流程</summary>
public abstract class NotificationService
{
    /// <summary>发送通知：流程由基类控制，发送器由子类决定</summary>
    public void Notify(string to, string content)
    {
        Console.WriteLine($"[通知] {ServiceName}开始发送");
        var sender = CreateSender();                   // 工厂方法：框架钩子，延迟到子类
        Console.WriteLine($"[创建] {sender.Channel}发送器已就位");
        sender.Send(to, content);
    }

    protected abstract string ServiceName { get; }     // 服务名

    /// <summary>工厂方法：由子类决定用哪种发送器</summary>
    protected abstract IMessageSender CreateSender();
}
