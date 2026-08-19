namespace TemplatePattern;

/// <summary>
/// 咖啡 —— 继承 Beverage，覆写冲泡和加料方法。
/// </summary>
class Coffee : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Add Coffee Grounds to water and boil");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Add Milk and Sugar");
    }
}
