namespace FlyweightPattern;

/// <summary>棋子工厂：按颜色缓存实例，保证全盘黑白各只有一个对象</summary>
public class GoStoneFactory
{
    private readonly Dictionary<string, GoStone> _stones = [];      // 共享池

    public int InstanceCount => _stones.Count;                     // 已创建实例数

    /// <summary>取棋子：有则复用，无则创建并入池</summary>
    public GoStone GetStone(string color) =>
        _stones.TryGetValue(color, out var stone)
            ? stone
            : _stones[color] = new GoStone(color, color == "黑" ? "云子窑烧" : "蛤碁石打磨");
}
