namespace BridgePattern;

/// <summary>
/// 剑类武器，组合附魔效果实现桥接。
/// </summary>
public class Sword(IEnchantment enchantment) : IWeapon
{
    private readonly IEnchantment _enchantment = enchantment;

    public void Wield()
    {
        Console.WriteLine("The sword is wielded.");
        _enchantment.OnActivate();
    }

    public void Swing()
    {
        Console.WriteLine("The sword is swinged.");
        _enchantment.Apply();
    }

    public void Unwield()
    {
        Console.WriteLine("The sword is unwielded.");
        _enchantment.OnDeactivate();
    }

    public IEnchantment GetEnchantment() => _enchantment;
}
