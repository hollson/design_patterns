namespace VisitorPattern;

/// <summary>
/// 客厅 —— 叶子节点，Accept() 直接调用 visitor.VisitLivingRoom 完成双重分派。
/// </summary>
public class LivingRoom : Unit
{
    public LivingRoom(params Unit[] units) : base(units) { }

    public override void Accept(IUnitVisitor visitor)
    {
        visitor.VisitLivingRoom(this);
        base.Accept(visitor);
    }

    public override string ToString() => "Living Room";
}
