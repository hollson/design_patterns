namespace BuilderPattern;

/// <summary>
/// 我的汉堡建造者，构建一个较大的风筝形汉堡。
/// </summary>
public class MyHamburgerBuilder : IBuilder
{
    private Hamburger _hamburger;

    public void AddIngredients()
    {
        _hamburger.Ingredients = ["Bread", "Meat", "Tomato", "Salad", "Mayonnaise"];
    }

    public void AddShape()
    {
        _hamburger.Shape = "Kite";
    }

    public void AddSize()
    {
        _hamburger.Size = 10; //inches
    }

    public void Reset()
    {
        _hamburger = new Hamburger();
    }

    public Hamburger Build()
    {
        return _hamburger;
    }
}
