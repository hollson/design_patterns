namespace FlyweightPattern;

/// <summary>
/// 椰奶奶茶，具体享元类，实现饮品接口。
/// </summary>
public class CoconutMilkTea : IBeverage
{
    public CoconutMilkTea() => Console.WriteLine("Initializing a Coconut Milk Tea instance");

    public void Drink() => Console.WriteLine("hmmm... this is coconut milk tea");
}
