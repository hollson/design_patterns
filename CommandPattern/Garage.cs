namespace CommandPattern;

/// <summary>
/// 车库接收者，执行打开和关闭车库门的实际操作
/// </summary>
internal class Garage
{
    private readonly string _name;

    public Garage(string name)
    {
        _name = name;
    }

    internal void Open()
    {
        Console.WriteLine($"{_name} Garage Opened");
    }

    internal void Close()
    {
        Console.WriteLine($"{_name} Garage Closed");
    }
}
