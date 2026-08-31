namespace AdapterPattern;

/// <summary>
/// 适配器，将火鸡(Turkey)的接口适配为鸭子(Duck)的接口。
/// 火鸡每次只能飞较短距离，因此适配器让火鸡连续飞5次来模拟鸭子的飞行。
/// </summary>
public class TurkeyAdapter : IDuck
{
    private readonly ITurkey _turkey;

    public TurkeyAdapter(ITurkey turkey)
    {
        _turkey = turkey;
    }

    public void Quack() => _turkey.Gobble();

    public void Fly()
    {
        for (var i = 0; i < 5; i++)
        {
            _turkey.Fly();
            Console.WriteLine("Resting..");
        }
    }
}
