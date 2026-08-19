namespace Ducks;

/// <summary>
/// 不会叫
/// </summary>
internal class QuackNope : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("...");
    }
}
