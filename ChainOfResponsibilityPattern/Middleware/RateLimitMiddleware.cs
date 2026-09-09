namespace ChainOfResponsibilityPattern;

/// <summary>限流中间件（具体处理者）：演示固定计数，超限 429 截断</summary>
public class RateLimitMiddleware(int limit = 3) : Middleware("限流中间件")
{
    private readonly Dictionary<string, int> _count = [];       // 每路径访问计数
    private readonly int _limit = limit;

    protected override bool Handle(HttpContext context, out bool intercepted)
    {
        Console.WriteLine($"[执行] 限流中间件：{context.Path} 已访问 {(_count.TryGetValue(context.Path, out var c) ? c : 0)}/{_limit} 次");
        int count = _count.GetValueOrDefault(context.Path) + 1;
        _count[context.Path] = count;

        if (count > _limit)
        {
            context.StatusCode = 429;
            context.Response = "Too Many Requests 触发限流";
            intercepted = true;                     // 截断：保护后端
            return true;
        }
        intercepted = false;
        return true;
    }
}
