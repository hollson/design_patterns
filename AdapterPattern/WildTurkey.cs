namespace AdapterPattern;

/// <summary>
/// 野火鸡，实现了火鸡接口的标准行为。
/// </summary>
class WildTurkey : ITurkey
{
    public void Gobble()
    {
        Console.WriteLine("Gobble Gobble Gobble");
    }

    public void Fly()
    {
        Console.WriteLine("Flies 100 Metres");
    }
}
