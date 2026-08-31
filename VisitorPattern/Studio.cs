namespace VisitorPattern;

/// <summary>
/// 单间公寓 —— 容器节点，Accept() 先处理自身再递归子单元。
/// </summary>
public class Studio : Unit
{
    public Studio(params Unit[] units) : base(units) { }

    public override void Accept(IUnitVisitor visitor)
    {
        visitor.VisitStudio(this);
        base.Accept(visitor);
    }

    public override string ToString() => "Studio";
}
