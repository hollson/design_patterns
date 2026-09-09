namespace VisitorPattern;

/// <summary>图书（具体元素）</summary>
public class Book(string name, decimal price) : Item(name, price)
{
    /// <summary>双分派第二步：把自己回传，访问者按"商品类型 + 操作类型"定位逻辑</summary>
    public override void Accept(IShoppingVisitor visitor) => visitor.VisitBook(this);
}
