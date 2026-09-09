namespace VisitorPattern;

/// <summary>食品（具体元素）</summary>
public class Food(string name, decimal price) : Item(name, price)
{
    public override void Accept(IShoppingVisitor visitor) => visitor.VisitFood(this);
}
