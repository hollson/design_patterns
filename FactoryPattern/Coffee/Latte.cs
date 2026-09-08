namespace FactoryPattern;

/// <summary>拿铁（具体产品）</summary>
public class Latte : Coffee
{
    public override string Name => "拿铁 Latte";
    public override decimal Price => 28m;
    public override string Recipe => "浓缩咖啡 + 蒸奶 + 细奶泡";
}
