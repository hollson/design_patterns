namespace CommandPattern;

/// <summary>
/// 接收者，执行开灯和关灯的实际操作。
/// </summary>
public class Light(string name)
{
    private readonly string _name = name;

    public void On() => Console.WriteLine($"{_name}灯已打开");

    public void Off() => Console.WriteLine($"{_name}灯已关闭");
}
