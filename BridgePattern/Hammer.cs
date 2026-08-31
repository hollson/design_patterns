namespace BridgePattern;

/// <summary>
/// 锤类武器，组合附魔效果实现桥接。
/// </summary>
public class Hammer(IEnchantment enchantment) : IWeapon
{
    private readonly IEnchantment _enchantment = enchantment;

    public void Wield() => DoAction("The hammer is wielded.", _enchantment.OnActivate);
    public void Swing() => DoAction("The hammer is swinged.", _enchantment.Apply);
    public void Unwield() => DoAction("The hammer is unwielded.", _enchantment.OnDeactivate);

    public IEnchantment GetEnchantment() => _enchantment;

    private static void DoAction(string message, Action action)
    {
        Console.WriteLine(message);
        action();
    }
}
