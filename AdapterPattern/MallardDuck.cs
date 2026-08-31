namespace AdapterPattern;

/// <summary>
/// 绿头鸭，实现了鸭子接口的标准行为。
/// </summary>
class MallardDuck : IDuck
{
    public void Quack() => Console.WriteLine("嘎嘎嘎");

    public void Fly() => Console.WriteLine("飞行 500 米");
}
