namespace VisitorPattern;

/// <summary>税费计算访问者（具体访问者）：不同商品类别适用不同税率</summary>
public class TaxVisitor : IShoppingVisitor
{
    public decimal TotalTax { get; private set; }        // 累计税额

    public void VisitBook(Book book)                     // 图书：9%
    {
        decimal tax = book.Price * 0.09m;
        TotalTax += tax;
        Console.WriteLine($"[税费] 《{book.Name}》¥{book.Price} × 9% = ¥{tax:0.00}");
    }

    public void VisitFood(Food food)                     // 食品：免税
    {
        Console.WriteLine($"[税费] {food.Name} ¥{food.Price} × 0% = 免税（初级农产品）");
    }

    public void VisitElectronics(Electronics e)          // 数码：13%
    {
        decimal tax = e.Price * 0.13m;
        TotalTax += tax;
        Console.WriteLine($"[税费] {e.Name} ¥{e.Price} × 13% = ¥{tax:0.00}");
    }
}
