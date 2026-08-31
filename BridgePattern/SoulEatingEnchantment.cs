namespace BridgePattern;

/// <summary>
/// 噬魂附魔，实现附魔接口的具体实现。
/// </summary>
public class SoulEatingEnchantment : IEnchantment
{
    public void OnActivate() => Console.WriteLine("物品散发嗜血气息。");

    public void Apply() => Console.WriteLine("物品吞噬敌人的灵魂。");

    public void OnDeactivate() => Console.WriteLine("嗜血气息慢慢消散。");
}
