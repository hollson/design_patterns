namespace CommandPattern;

/// <summary>
/// 调用者，只负责收集订单并排队，统一提交后厨，实现请求与执行的解耦。
/// </summary>
public class Waiter
{
    private readonly Queue<IOrder> _orders = new();

    // 点单：命令入队，无需立即执行
    public void TakeOrder(IOrder order)
    {
        _orders.Enqueue(order);
        Console.WriteLine($"服务员：新订单入队（当前待处理 {_orders.Count} 单）");
    }

    // 统一提交：按队列顺序依次执行
    public void SubmitOrders()
    {
        Console.WriteLine("服务员：订单统一提交后厨");
        while (_orders.Count > 0)
            _orders.Dequeue().Cook();
    }
}
