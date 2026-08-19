namespace FlyweightPattern;

/// <summary>
/// 奶茶店，客户端角色，通过工厂创建饮品并管理外带订单列表。
/// </summary>
public class BubbleTeaShop
{
    private List<IBeverage> takeAwayOrders;

    public BubbleTeaShop()
    {
        takeAwayOrders = [];
        TakeOrders();
    }

    private void TakeOrders()
    {
        var factory = new BeverageFlyweightFactory();

        takeAwayOrders.Add(factory.MakeBeverage(BeverageType.BubbleMilk));
        takeAwayOrders.Add(factory.MakeBeverage(BeverageType.BubbleMilk));
        takeAwayOrders.Add(factory.MakeBeverage(BeverageType.CoconutMilk));
        takeAwayOrders.Add(factory.MakeBeverage(BeverageType.FoamMilk));
        takeAwayOrders.Add(factory.MakeBeverage(BeverageType.OolongMilk));
        takeAwayOrders.Add(factory.MakeBeverage(BeverageType.OolongMilk));
    }

    public void Enumerate()
    {
        Console.WriteLine("Enumerating take away orders\n");
        foreach (var beverage in takeAwayOrders)
        {
            beverage.Drink();
        }
    }
}
