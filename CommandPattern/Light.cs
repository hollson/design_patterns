namespace CommandPattern;

/// <summary>
/// 灯光接收者，执行开灯和关灯的实际操作
/// </summary>
internal class Light
{
    private readonly string _name;

    public Light(string name)
    {
        _name = name;
    }

    internal void On()
    {
        Console.WriteLine($"{_name} Light On");
    }

    internal void Off()
    {
        Console.WriteLine($"{_name} Light Off");
    }
}
