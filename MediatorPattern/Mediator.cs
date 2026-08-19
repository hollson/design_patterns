namespace MediatorPattern;

/// <summary>
/// 中介者抽象基类，定义同事对象间的消息传递接口。
/// </summary>
abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}
