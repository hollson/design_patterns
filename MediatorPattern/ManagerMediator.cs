namespace MediatorPattern;

/// <summary>
/// 经理中介者，负责在客户、程序员和测试员之间协调消息转发。
/// </summary>
class ManagerMediator : Mediator
{
    public Colleague Customer { get; set; } = null!;
    public Colleague Programmer { get; set; } = null!;
    public Colleague Tester { get; set; } = null!;

    public override void Send(string message, Colleague colleague)
    {
        if (colleague == Customer)
            Programmer.Notify(message);
        else if (colleague == Programmer)
            Tester.Notify(message);
        else
            Customer.Notify(message);
    }
}
