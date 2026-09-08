namespace StatePattern;

/// <summary>
/// 已发货状态：确认收货后进入已完成，此时无法再取消。
/// </summary>
public class ShippedState : IOrderState
{
    public void Pay(Order order) => Console.WriteLine("[拒绝] 订单已支付");

    public void Ship(Order order) => Console.WriteLine("[拒绝] 请勿重复发货");

    public void Complete(Order order)
    {
        Console.WriteLine("[已完成] 确认收货，交易完成");
        order.State = order.Completed;
    }

    public void Cancel(Order order) => Console.WriteLine("[拒绝] 商品已发货，无法取消");
}
