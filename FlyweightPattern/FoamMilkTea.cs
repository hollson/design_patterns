namespace FlyweightPattern;

/// <summary>
/// 奶盖奶茶，具体享元类，实现饮品接口。
/// </summary>
public class FoamMilkTea : IBeverage
{
    public FoamMilkTea() => Console.WriteLine("初始化奶盖奶茶实例");

    public void Drink() => Console.WriteLine("嗯...这是奶盖奶茶");
}
