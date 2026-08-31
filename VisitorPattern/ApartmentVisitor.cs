namespace VisitorPattern;

/// <summary>
/// 公寓访问者 —— 仅对 Apartment 类型执行操作，忽略其他类型。
/// </summary>
public class ApartmentVisitor : IUnitVisitor
{
    public void VisitApartment(Apartment apartment) => Console.WriteLine("这是公寓");

    public void VisitStudio(Studio studio) { }

    public void VisitBedroom(Bedroom bedroom) { }

    public void VisitLivingRoom(LivingRoom livingRoom) { }
}
