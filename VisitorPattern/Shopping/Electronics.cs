namespace VisitorPattern;

/// <summary>数码产品（具体元素）</summary>
public class Electronics(string name, decimal price) : Item(name, price)
{
    public override void Accept(IShoppingVisitor visitor) => visitor.VisitElectronics(this);
}
