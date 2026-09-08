namespace FactoryPattern;

/// <summary>咖啡（抽象产品）：统一名称、价格与做法描述</summary>
public abstract class Coffee
{
    public abstract string Name { get; }

    public abstract decimal Price { get; }

    public abstract string Recipe { get; }       // 做法描述

    public void Display() => Console.WriteLine($"[下单] {Name} ¥{Price} — {Recipe}");
}
