namespace TemplatePattern;

/// <summary>
/// 咖啡 —— 继承 Beverage，覆写冲泡和加料方法。
/// </summary>
class Coffee : Beverage
{
    protected override void Brew() => Console.WriteLine("将咖啡粉加入水中煮沸");

    protected override void AddCondiments() => Console.WriteLine("加入牛奶和糖");
}
