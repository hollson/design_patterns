namespace BridgePattern;

/// <summary>
/// 附魔实现接口，定义附魔的生命周期方法。
/// </summary>
public interface IEnchantment
{
    void OnActivate();
    void Apply();
    void OnDeactivate();
}
