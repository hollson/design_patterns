namespace DecoratorPattern;

/// <summary>
/// 具体装饰器：日志装饰器，在真实处理前后插入埋点日志并统计耗时。
/// </summary>
public class LoggingHandler(IHandler handler) : HandlerDecorator(handler)
{
    public override void Handle(string request)
    {
        var sw = System.Diagnostics.Stopwatch.StartNew();
        Console.WriteLine("[LOG] 收到请求: " + request);

        _handler.Handle(request);

        sw.Stop();
        Console.WriteLine("[LOG] 处理完成: " + request + " 耗时 " + sw.ElapsedMilliseconds + "ms");
    }
}