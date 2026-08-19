namespace BuilderPattern;

/// <summary>
/// 建造者接口，定义了构建汉堡的各个步骤。
/// </summary>
public interface IBuilder
{
    void AddIngredients();
    void AddShape();
    void AddSize();
    void Reset();
    Hamburger Build();
}
