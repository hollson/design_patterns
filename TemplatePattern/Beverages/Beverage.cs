namespace TemplatePattern;

/// <summary>
/// 饮品抽象基类 —— 模板方法模式的核心。
/// Prepare() 定义了制作饮品的固定步骤顺序（算法骨架），
/// 子类只需覆写 Brew() 和 AddCondiments() 两个抽象方法即可。
/// </summary>
public abstract class Beverage
{
    // ReSharper disable once InconsistentNaming
    protected int _sugar;

    public void Prepare()
    {
        Boil();
        Brew();
        Pour();
        if (WantsCondiments)
            AddCondiments();
    }

    public bool WantsCondiments { private get; set; }

    protected abstract void Brew();

    private void Boil() => Console.WriteLine("Boling Water");

    private void Pour() => Console.WriteLine("Pouring in Cup");

    protected abstract void AddCondiments();

    public int AddSugar { get; set; }

    protected void Sugar() { }
}
