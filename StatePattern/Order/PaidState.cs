namespace StatePattern;

/// <summary>
/// 已支付状态：发货后进入已发货，取消需退款。
/// </summary>
public class PaidState : IOrderState
{
    public void Pay(Order order) => Console.WriteLine("[拒绝] 请勿重复支付");

    public void Ship(Order order)
    {
        Console.WriteLine("[已发货] 商品运输中");
        order.State = order.Shipped;
    }

    public void Complete(Order order) => Console.WriteLine("[拒绝] 商品尚未发货");

    public void Cancel(Order order)
    {
        Console.WriteLine("[已取消] 订单已取消，退款将原路退回");
        order.State = order.Cancelled;
    }
}
