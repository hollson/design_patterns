namespace StatePattern;

/// <summary>
/// 待支付状态：支付后进入已支付，可直接取消。
/// </summary>
public class PendingPaymentState : IOrderState
{
    public void Pay(Order order)
    {
        Console.WriteLine("[支付成功] 订单已支付，等待发货");
        order.State = order.Paid;
    }

    public void Ship(Order order) => Console.WriteLine("[拒绝] 请先支付");

    public void Complete(Order order) => Console.WriteLine("[拒绝] 订单尚未发货");

    public void Cancel(Order order)
    {
        Console.WriteLine("[已取消] 订单已取消");
        order.State = order.Cancelled;
    }
}
