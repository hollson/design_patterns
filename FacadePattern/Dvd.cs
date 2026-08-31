namespace FacadePattern;

/// <summary>
/// DVD光盘，封装影片名称信息。
/// </summary>
public class Dvd(string name)
{
    public string Movie { get; set; } = name;
}
