namespace FlyweightPattern;

/// <summary>
/// 珍珠奶茶，具体享元类，实现饮品接口。
/// </summary>
public class BubbleMilkTea : IBeverage
{
    public BubbleMilkTea() => Console.WriteLine("Initializing a Bubble Milk Tea instance");

    public void Drink() => Console.WriteLine("hmmm... this is bubble milk tea");
}
