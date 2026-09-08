namespace SingletonPattern;

/// <summary>
/// 日志记录器单例，使用 Lazy&lt;T&gt; 实现线程安全的延迟初始化：
/// 首次访问才打开日志文件（重资源），多线程并发获取也只创建一个实例。
/// </summary>
public class Logger
{
    private static readonly Lazy<Logger> _instance = new(() => new Logger());

    // 全局访问点
    public static Logger Instance => _instance.Value;

    private readonly string _logFile;

    // 私有构造，阻止外部 new
    private Logger()
    {
        _logFile = $"app-{DateTime.Now:HHmmss}.log";
        Console.WriteLine($"[初始化] 打开日志文件 {_logFile}（仅此一次）");
    }

    public void Info(string message) => Console.WriteLine($"[INFO] {message}");
}
