namespace FlyweightPattern;

/// <summary>
/// 奶盖奶茶，具体享元类，实现饮品接口。
/// </summary>
public class FoamMilkTea : IBeverage
{
    public FoamMilkTea() => Console.WriteLine("Initializing a Foam Milk Tea instance");

    public void Drink() => Console.WriteLine("hmmm... this is foam milk tea");
}
