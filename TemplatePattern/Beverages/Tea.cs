namespace TemplatePattern;

/// <summary>
/// 茶 —— 继承 Beverage，覆写冲泡和加料方法，并通过 new 隐藏基类成员提供自定义糖量控制。
/// </summary>
class Tea : Beverage
{
    protected override void Brew() => Console.WriteLine("将茶叶加入水中煮沸");

    protected override void AddCondiments()
    {
        Console.WriteLine("加入柠檬和糖");
        Sugar();
    }

    private new void Sugar() => Console.WriteLine($"加入 {_sugar} 勺糖");

    public new int AddSugar { set => _sugar = value; }
}
