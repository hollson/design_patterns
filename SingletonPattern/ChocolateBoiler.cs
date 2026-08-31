namespace SingletonPattern;

/// <summary>
/// 巧克力锅炉单例类，使用 Lazy&lt;T&gt; 实现线程安全的延迟初始化。
/// 锅炉有三种状态：空(Empty)、进行中(InProgress)、已煮沸(Boiled)。
/// </summary>
internal class ChocolateBoiler
{
    /// <summary>
    /// 锅炉状态枚举，表示当前处理阶段。
    /// </summary>
    private enum Status
    {
        Empty,
        InProgress,
        Boiled
    }

    private static readonly Lazy<ChocolateBoiler> _singleton = new(() => new ChocolateBoiler());

    public static ChocolateBoiler GetInstance() => _singleton.Value;

    private Status _boiler;

    private ChocolateBoiler()
    {
        Console.WriteLine("启动中");
        _boiler = Status.Empty;
    }

    public void Fill() => Transition(() => IsEmpty, "加料中...", Status.InProgress);

    public void Drain() => Transition(() => IsBoiled, "排空...", Status.Empty);

    public void Boil() => Transition(() => !IsBoiled && !IsEmpty, "煮沸中...", Status.Boiled);

    private void Transition(Func<bool> canTransition, string message, Status newStatus)
    {
        if (!canTransition()) return;
        Console.WriteLine(message);
        _boiler = newStatus;
    }

    private bool IsEmpty => _boiler == Status.Empty;

    private bool IsBoiled => _boiler == Status.Boiled;
}
