namespace StatePattern;

/// <summary>
/// 已完成状态：终结状态，所有操作均被拒绝。
/// </summary>
public class CompletedState : IOrderState
{
    public void Pay(Order order) => Console.WriteLine("[拒绝] 订单已完成");

    public void Ship(Order order) => Console.WriteLine("[拒绝] 订单已完成");

    public void Complete(Order order) => Console.WriteLine("[拒绝] 订单已完成");

    public void Cancel(Order order) => Console.WriteLine("[拒绝] 订单已完成，无法取消");
}
