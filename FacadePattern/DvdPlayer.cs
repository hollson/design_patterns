namespace FacadePattern;

/// <summary>
/// DVD播放器，提供开机、插入光盘、播放、暂停、恢复等操作。
/// </summary>
public class DvdPlayer
{
    private Dvd? _dvd;
    private int _time = 0;
    public void On() => Console.WriteLine("DVD播放器已开机");

    public void Insert(Dvd dvd)
    {
        _dvd = dvd;
        Console.WriteLine($"正在插入 {dvd.Movie}");

    }

    public void Play() => Console.WriteLine($"正在播放 {_dvd?.Movie}");

    public void Pause()
    {
        Console.WriteLine($"暂停于 {_time = new Random().Next(_time, _time + 120)}");
    }

    public void Resume()
    {
        Console.WriteLine($"从 {_time} 恢复播放");
    }
}
