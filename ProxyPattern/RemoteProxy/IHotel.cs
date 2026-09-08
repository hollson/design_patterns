namespace ProxyPattern;

/// <summary>
/// 酒店预订接口，客户端只依赖它，不感知远程细节。
/// </summary>
public interface IHotel
{
    void Book(string room);
}