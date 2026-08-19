namespace Ducks;

/// <summary>
/// 正常呱呱叫
/// </summary>
class QuackNormal : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Quack Quack");
    }
}
