namespace FactoryPattern;

/// <summary>咖啡工厂（简单工厂·switch 版）：一个静态方法集中管理所有产品的创建</summary>
public static class CoffeeFactory
{
    /// <summary>按品类制作咖啡——新增品类必须修改这里的分支</summary>
    public static Coffee Create(CoffeeType type) => type switch
    {
        CoffeeType.Latte     => new Latte(),
        CoffeeType.Americano => new Americano(),
        CoffeeType.Mocha     => new Mocha(),
        _ => throw new NotSupportedException($"未知咖啡类型：{type}"),
    };
}
