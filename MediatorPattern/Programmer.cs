namespace MediatorPattern;

/// <summary>
/// 程序员同事类，通过中介者接收和发送开发消息。
/// </summary>
class Programmer : Colleague
{
    public Programmer(Mediator mediator) : base(mediator) { }

    public override void Notify(string message) => Console.WriteLine($"程序员收到消息：{message}");
}
