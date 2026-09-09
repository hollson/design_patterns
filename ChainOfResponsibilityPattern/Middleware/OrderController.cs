namespace ChainOfResponsibilityPattern;

/// <summary>业务控制器（链的末端）：真正的业务处理</summary>
public class OrderController() : Middleware("订单控制器")
{
    protected override bool Handle(HttpContext context, out bool intercepted)
    {
        Console.WriteLine($"[执行] 订单控制器：处理业务 {context.Path}");
        context.StatusCode = 200;
        context.Response = "OK 订单创建成功";
        intercepted = true;                         // 末端：处理完自然终止
        return true;
    }
}
