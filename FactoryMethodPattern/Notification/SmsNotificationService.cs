namespace FactoryMethodPattern;

/// <summary>短信通知服务（具体创建者）</summary>
public class SmsNotificationService : NotificationService
{
    protected override string ServiceName => "短信通知服务";

    protected override IMessageSender CreateSender() => new SmsSender();
}
