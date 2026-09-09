// 职责链模式：请求沿处理者链传递，每个处理者决定处理或转发

using ChainOfResponsibilityPattern;

Console.WriteLine("========== 责任链模式 (Chain of Responsibility) ==========");
Console.WriteLine("请求沿链传递，每个处理者决定处理或转交下一位\n");

Console.WriteLine("--- 经典场景: 公司报销审批 ---");
Console.WriteLine(">> 审批链：组长(≤500) → 经理(≤5000) → 总监(≤5万) → CEO(不限)\n");

// 链式组装审批链
Approver chain = new TeamLead("组长老王");
chain.SetNext(new Manager("经理老李"))
     .SetNext(new Director("张总监"))
     .SetNext(new Ceo("赵总"));

ExpenseRequest[] requests =
[
    new("小陈", "团建零食", 320m),
    new("小周", "差旅费", 3_800m),
    new("小吴", "展会物料", 28_000m),
    new("小郑", "服务器采购", 500_000m),
];

foreach (var request in requests)
{
    Console.WriteLine($">> {request.Applicant} 提交「{request.Purpose}」¥{request.Amount}");
    chain.Process(request);
    Console.WriteLine();
}

Console.WriteLine("--- 软件项目: HTTP 中间件管道 ---");
Console.WriteLine(">> 管道：认证 → 限流 → 日志 → 控制器（ASP.NET Core 的核心机制）\n");

// 组装中间件管道
Middleware pipeline = new AuthMiddleware();
pipeline.Use(new RateLimitMiddleware())
        .Use(new LoggingMiddleware())
        .Use(new OrderController());

HttpContext[] httpRequests =
[
    new("GET", "/api/orders") { Token = "jwt-token-abc" },        // 正常请求
    new("GET", "/api/orders"),                                     // 未认证 → 401
    new("GET", "/api/orders") { Token = "jwt-token-abc" },         // 正常
    new("GET", "/api/orders") { Token = "jwt-token-abc" },         // 正常
    new("GET", "/api/orders") { Token = "jwt-token-abc" },         // 第 4 次 → 429
];

foreach (var request in httpRequests)
{
    Console.WriteLine($">> 请求进入管道：{request.Method} {request.Path}（Token：{request.Token ?? "无"}）");
    await pipeline.InvokeAsync(request);
    Console.WriteLine();
}
