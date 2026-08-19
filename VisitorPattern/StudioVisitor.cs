namespace VisitorPattern;

/// <summary>
/// 单间公寓访问者 —— 仅对 Studio 类型执行操作，忽略其他类型。
/// </summary>
public class StudioVisitor : IUnitVisitor
{
    public void VisitApartment(Apartment apartment)
    {
    }

    public void VisitStudio(Studio studio)
    {
        Console.WriteLine("This is a studio");
    }

    public void VisitBedroom(Bedroom bedroom)
    {
    }

    public void VisitLivingRoom(LivingRoom livingRoom)
    {
    }
}
