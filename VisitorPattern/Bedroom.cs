namespace VisitorPattern;

/// <summary>
/// 卧室 —— 叶子节点，Accept() 直接调用 visitor.VisitBedroom 完成双重分派。
/// </summary>
public class Bedroom : Unit
{
    public Bedroom(params Unit[] units) : base(units)
    {
    }

    public override void Accept(IUnitVisitor visitor)
    {
        visitor.VisitBedroom(this);
        base.Accept(visitor);
    }

    public override string ToString()
    {
        return "Bedroom";
    }
}
