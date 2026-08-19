namespace FacadePattern;

/// <summary>
/// DVD光盘，封装影片名称信息。
/// </summary>
public class Dvd
{
    public Dvd(string name)
    {
        Movie = name;
    }
    public string Movie { get; set; }
}
