namespace AdapterPattern;

/// <summary>
/// 绿头鸭，实现了鸭子接口的标准行为。
/// </summary>
class MallardDuck : IDuck
{
    public void Quack() => Console.WriteLine("Quack Quack Quack");

    public void Fly() => Console.WriteLine("Flies 500 Metres");
}
