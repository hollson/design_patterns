namespace ChainOfResponsibilityPattern;

/// <summary>日志中间件（具体处理者）：记录请求，永不截断</summary>
public class LoggingMiddleware() : Middleware("日志中间件")
{
    protected override bool Handle(HttpContext context, out bool intercepted)
    {
        Console.WriteLine($"[执行] 日志中间件：记录 {context.Method} {context.Path}");
        intercepted = false;                        // 只旁路记录，不影响流转
        return true;
    }
}
