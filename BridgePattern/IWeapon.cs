namespace BridgePattern;

/// <summary>
/// 武器抽象接口，定义武器的基本操作。
/// </summary>
public interface IWeapon
{
    void Wield();
    void Swing();
    void Unwield();
    IEnchantment GetEnchantment();
}
