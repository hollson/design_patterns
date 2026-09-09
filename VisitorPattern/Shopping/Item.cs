namespace VisitorPattern;

/// <summary>商品（抽象元素）：接受访问者，把"我是谁"回传给访问者</summary>
public abstract class Item(string name, decimal price)
{
    public string Name { get; } = name;

    public decimal Price { get; } = price;

    /// <summary>双分派第一步：调用者只管 Accept，具体走哪个 Visit 由元素类型决定</summary>
    public abstract void Accept(IShoppingVisitor visitor);
}
