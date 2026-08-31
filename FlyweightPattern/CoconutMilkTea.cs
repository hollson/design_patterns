namespace FlyweightPattern;

/// <summary>
/// 椰奶奶茶，具体享元类，实现饮品接口。
/// </summary>
public class CoconutMilkTea : IBeverage
{
    public CoconutMilkTea() => Console.WriteLine("初始化椰奶奶茶实例");

    public void Drink() => Console.WriteLine("嗯...这是椰奶奶茶");
}
