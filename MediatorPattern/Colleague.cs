namespace MediatorPattern;

/// <summary>
/// 同事抽象基类，持有中介者引用，通过中介者发送和接收消息。
/// </summary>
abstract class Colleague
{
    protected Mediator mediator;

    public Colleague(Mediator mediator) => this.mediator = mediator;

    public virtual void Send(string message) => this.mediator.Send(message, this);

    public abstract void Notify(string message);
}
