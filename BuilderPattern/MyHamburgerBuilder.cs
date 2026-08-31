namespace BuilderPattern;

/// <summary>
/// 我的汉堡建造者，构建一个较大的风筝形汉堡。
/// </summary>
public class MyHamburgerBuilder : IBuilder
{
    private Hamburger _hamburger = null!;

    public void AddIngredients() => _hamburger.Ingredients = ["面包", "肉", "番茄", "沙拉", "蛋黄酱"];

    public void AddShape() => _hamburger.Shape = "风筝形";

    public void AddSize() => _hamburger.Size = 10; //inches

    public void Reset() => _hamburger = new Hamburger();

    public Hamburger Build() => _hamburger;
}
