namespace VisitorPattern;

/// <summary>
/// 公寓 —— 组合模式中的容器节点，包含多个子单元。
/// Accept() 先让访问者处理自身，再递归遍历子单元。
/// </summary>
public class Apartment : Unit
{
    public Apartment(params Unit[] units) : base(units)
    {
    }

    public override void Accept(IUnitVisitor visitor)
    {
        visitor.VisitApartment(this);
        base.Accept(visitor);
    }

    public override string ToString()
    {
        return "Apartment";
    }
}
