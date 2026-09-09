namespace VisitorPattern;

/// <summary>购物访问者（抽象访问者）：对每类商品定义一个 Visit 方法</summary>
public interface IShoppingVisitor
{
    void VisitBook(Book book);                    // 访问图书

    void VisitFood(Food food);                    // 访问食品

    void VisitElectronics(Electronics electronics);   // 访问数码
}
