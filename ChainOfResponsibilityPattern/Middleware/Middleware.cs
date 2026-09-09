namespace ChainOfResponsibilityPattern;

/// <summary>中间件（抽象处理者）：处理请求后决定放行或截断</summary>
public abstract class Middleware(string name)
{
    private Middleware? _next;                      // 管道中的下一环

    protected string Name { get; } = name;

    /// <summary>串起下一环（返回 next 便于 fluent 组装）</summary>
    public Middleware Use(Middleware next)
    {
        _next = next;
        return next;
    }

    /// <summary>处理请求：要么截断返回，要么调下一环</summary>
    public Task InvokeAsync(HttpContext context)
    {
        if (Handle(context, out bool intercepted))
        {
            if (intercepted)
            {
                Console.WriteLine($"[截断] {Name} 终止管道：{(int)context.StatusCode} {context.Response}");
                return Task.CompletedTask;          // 不再往下传
            }
            if (_next is not null)
            {
                Console.WriteLine($"[放行] {Name} 检查通过，进入下一环");
                return _next.InvokeAsync(context);  // 传给下一环
            }
        }
        return Task.CompletedTask;
    }

    /// <summary>本环处理逻辑：返回是否已处理，intercepted=true 表示截断</summary>
    protected abstract bool Handle(HttpContext context, out bool intercepted);
}
