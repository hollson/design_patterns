namespace TemplatePattern;

/// <summary>
/// 茶 —— 继承 Beverage，覆写冲泡和加料方法，并通过 new 隐藏基类成员提供自定义糖量控制。
/// </summary>
class Tea : Beverage
{
    protected override void Brew() => Console.WriteLine("Adding tea leaves to water and boil");

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding Lemon and Sugar");
        Sugar();
    }

    private new void Sugar() => Console.WriteLine($"adding {_sugar} spoons of sugar");

    public new int AddSugar { set => _sugar = value; }
}
