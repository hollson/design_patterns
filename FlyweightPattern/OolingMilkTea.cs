namespace FlyweightPattern;

/// <summary>
/// 乌龙奶茶，具体享元类，实现饮品接口。
/// </summary>
public class OolingMilkTea : IBeverage
{

    public OolingMilkTea()
    {
        Console.WriteLine("Initializing an Oolong Milk Tea instance");
    }

    public void Drink()
    {
        Console.WriteLine("hmmm... this is oolong milk tea");
    }
}
