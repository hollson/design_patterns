namespace BridgePattern;

/// <summary>
/// 飞行附魔，实现附魔接口的具体实现。
/// </summary>
public class FlyingEnchantment : IEnchantment
{
    public void OnActivate() => Console.WriteLine("物品开始发出微光。");

    public void Apply() => Console.WriteLine("物品飞出击中敌人后回到主人手中。");

    public void OnDeactivate() => Console.WriteLine("物品的光芒消退。");
}
