namespace CommandPattern;

/// <summary>
/// 接收者，执行打开和关闭车库门的实际操作。
/// </summary>
public class Garage(string name)
{
    private readonly string _name = name;

    public void Open() => Console.WriteLine($"{_name}门已打开");

    public void Close() => Console.WriteLine($"{_name}门已关闭");
}
