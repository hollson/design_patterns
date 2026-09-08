namespace StatePattern;

/// <summary>
/// 已取消状态：终结状态，所有操作均被拒绝。
/// </summary>
public class CancelledState : IOrderState
{
    public void Pay(Order order) => Console.WriteLine("[拒绝] 订单已取消");

    public void Ship(Order order) => Console.WriteLine("[拒绝] 订单已取消");

    public void Complete(Order order) => Console.WriteLine("[拒绝] 订单已取消");

    public void Cancel(Order order) => Console.WriteLine("[拒绝] 订单已取消");
}
