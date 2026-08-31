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
        Console.WriteLine("Starting");
        _boiler = Status.Empty;
    }

    public void Fill() => Transition(() => IsEmpty, "Filling...", Status.InProgress);

    public void Drain() => Transition(() => IsBoiled, "Draining...", Status.Empty);

    public void Boil() => Transition(() => !IsBoiled && !IsEmpty, "Boiling...", Status.Boiled);

    private void Transition(Func<bool> canTransition, string message, Status newStatus)
    {
        if (!canTransition()) return;
        Console.WriteLine(message);
        _boiler = newStatus;
    }

    private bool IsEmpty => _boiler == Status.Empty;

    private bool IsBoiled => _boiler == Status.Boiled;
}
