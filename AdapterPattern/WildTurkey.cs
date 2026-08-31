namespace AdapterPattern;

/// <summary>
/// 野火鸡，实现了火鸡接口的标准行为。
/// </summary>
class WildTurkey : ITurkey
{
    public void Gobble() => Console.WriteLine("咯咯咯");

    public void Fly() => Console.WriteLine("飞行 100 米");
}
