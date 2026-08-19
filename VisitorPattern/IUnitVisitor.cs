namespace VisitorPattern;

/// <summary>
/// 访问者接口 —— 定义了对每种 Unit 具体类型的 Visit 方法。
/// 访问者模式的关键：每增加一种新的操作，只需新增一个 IUnitVisitor 实现，
/// 无需修改已有的元素类，符合开闭原则。
/// </summary>
public interface IUnitVisitor
{
    void VisitApartment(Apartment apartment);
    void VisitStudio(Studio studio);
    void VisitBedroom(Bedroom bedroom);
    void VisitLivingRoom(LivingRoom livingRoom);
}
