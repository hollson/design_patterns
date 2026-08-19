namespace VisitorPattern;

/// <summary>
/// 卧室访问者 —— 仅对 Bedroom 类型执行操作，忽略其他类型。
/// </summary>
public class BedroomVisitor : IUnitVisitor
{
    public void VisitApartment(Apartment apartment)
    {
    }

    public void VisitStudio(Studio studio)
    {
    }

    public void VisitBedroom(Bedroom bedroom)
    {
        Console.WriteLine("Here is a bedroom");
    }

    public void VisitLivingRoom(LivingRoom livingRoom)
    {
    }
}
