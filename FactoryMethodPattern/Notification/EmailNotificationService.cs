namespace FactoryMethodPattern;

/// <summary>邮件通知服务（具体创建者）</summary>
public class EmailNotificationService : NotificationService
{
    protected override string ServiceName => "邮件通知服务";

    protected override IMessageSender CreateSender() => new EmailSender();
}
