namespace BridgePattern;

/// <summary>
/// 剑类武器，组合附魔效果实现桥接。
/// </summary>
public class Sword(IEnchantment enchantment) : IWeapon
{
    private readonly IEnchantment _enchantment = enchantment;

    public void Wield() => DoAction("剑已拔出。", _enchantment.OnActivate);
    public void Swing() => DoAction("剑已挥动。", _enchantment.Apply);
    public void Unwield() => DoAction("剑已收回。", _enchantment.OnDeactivate);

    public IEnchantment GetEnchantment() => _enchantment;

    private static void DoAction(string message, Action action)
    {
        Console.WriteLine(message);
        action();
    }
}
