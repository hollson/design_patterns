namespace VisitorPattern;

/// <summary>会员折扣访问者（具体访问者）：同一批商品，第二种操作——新增操作零改动商品类</summary>
public class DiscountVisitor : IShoppingVisitor
{
    public decimal TotalPayable { get; private set; }    // 折后应付累计

    public void VisitBook(Book book)                     // 图书满 50 减 10
    {
        decimal payable = book.Price >= 50 ? book.Price - 10 : book.Price;
        TotalPayable += payable;
        Console.WriteLine($"[折扣] 《{book.Name}》¥{book.Price} → ¥{payable:0.00}（图书满50减10）");
    }

    public void VisitFood(Food food)                     // 食品不参与折扣
    {
        TotalPayable += food.Price;
        Console.WriteLine($"[折扣] {food.Name} ¥{food.Price}（食品不参与折扣）");
    }

    public void VisitElectronics(Electronics e)          // 数码 95 折
    {
        decimal payable = e.Price * 0.95m;
        TotalPayable += payable;
        Console.WriteLine($"[折扣] {e.Name} ¥{e.Price} → ¥{payable:0.00}（数码95折）");
    }
}
