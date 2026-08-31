namespace FlyweightPattern;

/// <summary>
/// 珍珠奶茶，具体享元类，实现饮品接口。
/// </summary>
public class BubbleMilkTea : IBeverage
{
    public BubbleMilkTea() => Console.WriteLine("初始化珍珠奶茶实例");

    public void Drink() => Console.WriteLine("嗯...这是珍珠奶茶");
}
