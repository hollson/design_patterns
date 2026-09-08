namespace FactoryPattern;

/// <summary>摩卡（具体产品）</summary>
public class Mocha : Coffee
{
    public override string Name => "摩卡 Mocha";
    public override decimal Price => 32m;
    public override string Recipe => "浓缩咖啡 + 巧克力酱 + 蒸奶 + 奶泡";
}
