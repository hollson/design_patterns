namespace TemplatePattern;

/// <summary>咖啡（具体类）：同一套流程骨架，另一个实现</summary>
public class Coffee : Beverage
{
    protected override void Brew() => Console.WriteLine("[咖啡] 用 92℃ 热水滴滤咖啡粉");

    protected override void AddCondiments() => Console.WriteLine("[咖啡] 加糖和牛奶");

    /// <summary>覆写钩子：这杯不加料</summary>
    protected override bool WantsCondiments() => false;
}
