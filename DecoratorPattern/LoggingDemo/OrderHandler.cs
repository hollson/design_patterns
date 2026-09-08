namespace DecoratorPattern;

/// <summary>
/// 具体组件：下单处理器，实际执行业务逻辑（校验 + 落库）。
/// </summary>
public class OrderHandler : IHandler
{
    public void Handle(string request)
    {
        Console.WriteLine("校验订单: " + request);
        Thread.Sleep(50); // 模拟数据库写入延迟
        Console.WriteLine("订单入库成功");
    }
}