namespace StatePattern;

/// <summary>
/// 上下文，电商订单：支付/发货/收货/取消全部委托给当前状态，
/// 同一操作在不同状态下产生不同结果。
/// </summary>
public class Order
{
    public string Id { get; }

    public IOrderState State { get; set; }

    public IOrderState PendingPayment { get; }

    public IOrderState Paid { get; }

    public IOrderState Shipped { get; }

    public IOrderState Completed { get; }

    public IOrderState Cancelled { get; }

    public Order(string id)
    {
        Id = id;
        PendingPayment = new PendingPaymentState();
        Paid = new PaidState();
        Shipped = new ShippedState();
        Completed = new CompletedState();
        Cancelled = new CancelledState();
        State = PendingPayment;
        Console.WriteLine($"[创建] 订单 {id} 已创建，等待支付");
    }

    public void Pay() => State.Pay(this);

    public void Ship() => State.Ship(this);

    public void Complete() => State.Complete(this);

    public void Cancel() => State.Cancel(this);
}
