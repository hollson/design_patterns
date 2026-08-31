namespace Ducks;

/// <summary>
/// 不会飞
/// </summary>
class FlyNope : IFlyBehaviour
{
    public void Fly() => Console.WriteLine("I can't fly");
}
