namespace ChainOfResponsibilityPattern;

/// <summary>认证中间件（具体处理者）：无 Token 直接 401 截断</summary>
public class AuthMiddleware() : Middleware("认证中间件")
{
    protected override bool Handle(HttpContext context, out bool intercepted)
    {
        Console.WriteLine($"[执行] 认证中间件：{context.Method} {context.Path}");
        if (context.Token is null)
        {
            context.StatusCode = 401;
            context.Response = "Unauthorized 未认证";
            intercepted = true;                     // 截断：不进入后续环节
            return true;
        }
        intercepted = false;
        return true;                                // 放行
    }
}
