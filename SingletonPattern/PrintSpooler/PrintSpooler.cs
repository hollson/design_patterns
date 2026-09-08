namespace SingletonPattern;

/// <summary>
/// 打印机后台队列单例：全办公室共用一台打印机，文档必须进入同一队列；
/// 若出现多个队列实例，不同电脑的文档会互相看不见，打印顺序失控。
/// </summary>
public class PrintSpooler
{
    private static readonly Lazy<PrintSpooler> _instance = new(() => new PrintSpooler());

    public static PrintSpooler Instance => _instance.Value;

    private readonly Queue<string> _documents = new();

    private PrintSpooler() => Console.WriteLine("[初始化] 打印服务已启动，等待任务入队");

    // 任意工位提交文档，进入唯一队列
    public void Submit(string computer, string doc)
    {
        _documents.Enqueue(doc);
        Console.WriteLine($"{computer} 提交打印: {doc}");
    }

    // 按提交顺序依次出队打印
    public void PrintAll()
    {
        while (_documents.Count > 0)
            Console.WriteLine($"正在打印: {_documents.Dequeue()}");
    }
}
