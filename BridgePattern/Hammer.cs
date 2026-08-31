namespace BridgePattern;

/// <summary>
/// 锤类武器，组合附魔效果实现桥接。
/// </summary>
public class Hammer(IEnchantment enchantment) : IWeapon
{
    private readonly IEnchantment _enchantment = enchantment;

    public void Wield() => DoAction("锤子已挥起。", _enchantment.OnActivate);
    public void Swing() => DoAction("锤子已挥动。", _enchantment.Apply);
    public void Unwield() => DoAction("锤子已放下。", _enchantment.OnDeactivate);

    public IEnchantment GetEnchantment() => _enchantment;

    private static void DoAction(string message, Action action)
    {
        Console.WriteLine(message);
        action();
    }
}
