namespace FlyweightPattern;

/// <summary>
/// 乌龙奶茶，具体享元类，实现饮品接口。
/// </summary>
public class OolingMilkTea : IBeverage
{
    public OolingMilkTea() => Console.WriteLine("初始化乌龙奶茶实例");

    public void Drink() => Console.WriteLine("嗯...这是乌龙奶茶");
}
