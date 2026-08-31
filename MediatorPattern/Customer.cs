namespace MediatorPattern;

/// <summary>
/// 客户同事类，通过中介者发送需求消息。
/// </summary>
class Customer : Colleague
{
    public Customer(Mediator mediator) : base(mediator) { }

    public override void Notify(string message) => Console.WriteLine($"客户收到消息：{message}");
}
