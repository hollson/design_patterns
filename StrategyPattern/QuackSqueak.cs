namespace Ducks;

/// <summary>
/// 吱吱叫
/// </summary>
class QuackSqueak : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Squeeeak");
    }
}
