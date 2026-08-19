namespace FlyweightPattern;

/// <summary>
/// 享元工厂，负责创建和缓存饮品实例，确保相同类型的饮品只创建一次。
/// </summary>
public class BeverageFlyweightFactory
{
    private readonly Dictionary<BeverageType, IBeverage> _beverages = [];

    public IBeverage MakeBeverage(BeverageType type)
    {
        if (!_beverages.TryGetValue(type, out var beverage))
        {
            switch (type)
            {
                case BeverageType.BubbleMilk:
                    beverage = new BubbleMilkTea();
                    _beverages.Add(BeverageType.BubbleMilk, beverage);
                    break;
                case BeverageType.FoamMilk:
                    beverage = new FoamMilkTea();
                    _beverages.Add(BeverageType.FoamMilk, beverage);
                    break;
                case BeverageType.OolongMilk:
                    beverage = new OolingMilkTea();
                    _beverages.Add(BeverageType.OolongMilk, beverage);
                    break;
                case BeverageType.CoconutMilk:
                    beverage = new CoconutMilkTea();
                    _beverages.Add(BeverageType.CoconutMilk, beverage);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        return beverage;
    }
}
