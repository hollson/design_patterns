namespace VisitorPattern;

/// <summary>
/// 客厅访问者 —— 仅对 LivingRoom 类型执行操作，忽略其他类型。
/// </summary>
public class LivingRoomVisitor : IUnitVisitor
{
    public void VisitApartment(Apartment apartment) { }

    public void VisitStudio(Studio studio) { }

    public void VisitBedroom(Bedroom bedroom) { }

    public void VisitLivingRoom(LivingRoom livingRoom) => Console.WriteLine("This is the living room");
}
