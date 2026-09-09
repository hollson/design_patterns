namespace TemplatePattern;

/// <summary>茶（具体类）：只回答"怎么泡、加什么"</summary>
public class Tea : Beverage
{
    protected override void Brew() => Console.WriteLine("[茶] 用 85℃ 热水浸泡茶叶 3 分钟");

    protected override void AddCondiments() => Console.WriteLine("[茶] 加一片柠檬");
}
