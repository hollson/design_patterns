namespace TemplatePattern;

/// <summary>饮品（抽象类）：Prepare() 是模板方法，固化冲泡流程骨架</summary>
public abstract class Beverage
{
    /// <summary>模板方法：烧水 → 冲泡 → 倒杯 → 加料，步骤顺序固定，不可覆写</summary>
    public void Prepare()
    {
        BoilWater();                       // 固定步骤：直接实现
        Brew();                            // 变化步骤：延迟到子类
        PourInCup();                       // 固定步骤
        if (WantsCondiments())             // 钩子：子类可决定是否加料
            AddCondiments();
    }

    /// <summary>冲泡：茶与咖啡各不相同，子类必须实现</summary>
    protected abstract void Brew();

    /// <summary>加料：柠檬/糖/奶，子类必须实现</summary>
    protected abstract void AddCondiments();

    /// <summary>钩子方法：默认加料，子类可覆写关闭（如无糖党）</summary>
    protected virtual bool WantsCondiments() => true;

    private void BoilWater() => Console.WriteLine("[固定] 把水烧开");

    private void PourInCup() => Console.WriteLine("[固定] 倒进杯子");
}
