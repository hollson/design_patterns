namespace FactoryPattern;

/// <summary>美式（具体产品）</summary>
public class Americano : Coffee
{
    public override string Name => "美式 Americano";
    public override decimal Price => 22m;
    public override string Recipe => "浓缩咖啡 + 热水";
}
