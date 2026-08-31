namespace BuilderPattern;

/// <summary>
/// 厨师类，作为指挥者(Director)协调建造者按步骤构建汉堡。
/// </summary>
public class Cook
{
    private IBuilder _builder = null!;

    public Cook(IBuilder builder)
    {
        AcceptBuilder(builder);
    }

    public void ChangeBuilder(IBuilder builder)
    {
        AcceptBuilder(builder);
    }

    public Hamburger Build()
    {
        _builder.AddIngredients();
        _builder.AddShape();
        _builder.AddSize();
        return _builder.Build();
    }

    private void AcceptBuilder(IBuilder builder)
    {
        _builder = builder;
        _builder.Reset();
    }
}
