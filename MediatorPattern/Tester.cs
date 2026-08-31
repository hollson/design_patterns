namespace MediatorPattern;

/// <summary>
/// 测试员同事类，通过中介者接收和发送测试消息。
/// </summary>
class Tester : Colleague
{
    public Tester(Mediator mediator) : base(mediator) { }

    public override void Notify(string message) => Console.WriteLine($"Message to tester: {message}");
}
