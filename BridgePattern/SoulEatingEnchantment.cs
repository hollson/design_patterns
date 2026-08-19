namespace BridgePattern;

/// <summary>
/// 噬魂附魔，实现附魔接口的具体实现。
/// </summary>
public class SoulEatingEnchantment : IEnchantment
{
    public void OnActivate() => Console.WriteLine("The item spreads bloodlust.");

    public void Apply() => Console.WriteLine("The item eats the soul of enemies.");

    public void OnDeactivate() => Console.WriteLine("Bloodlust slowly disappears.");
}
