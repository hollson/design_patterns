namespace BridgePattern;

/// <summary>
/// 飞行附魔，实现附魔接口的具体实现。
/// </summary>
public class FlyingEnchantment : IEnchantment
{
    public void OnActivate() => Console.WriteLine("The item begins to glow faintly.");

    public void Apply() => Console.WriteLine("The item flies and strikes the enemies finally returning to owner's hand.");

    public void OnDeactivate() => Console.WriteLine("The item's glow fades.");
}
