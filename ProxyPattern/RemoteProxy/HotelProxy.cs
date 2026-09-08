namespace ProxyPattern;

/// <summary>
/// 远程代理，本地封装远程调用细节，客户端无需感知网络。
/// </summary>
public class HotelProxy : IHotel
{
    private readonly RealHotel _real = new RealHotel();

    public void Book(string room) => _real.Book(room);
}