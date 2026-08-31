namespace FacadePattern;

/// <summary>
/// 家庭影院外观类，封装了调光器、DVD播放器等子系统的复杂操作，
/// 提供统一的观影、暂停、恢复接口。
/// </summary>
public class HomeTheatreFacade(Dimmer dimmer, Dvd dvd, DvdPlayer dvdPlayer)
{
    private readonly Dimmer _dimmer = dimmer;
    private readonly Dvd _dvd = dvd;
    private readonly DvdPlayer _dvdPlayer = dvdPlayer;

    public void WatchMovie()
    {
        _dimmer.Dim(5);
        _dvdPlayer.On();
        _dvdPlayer.Insert(_dvd);
        _dvdPlayer.Play();
    }

    public void Pause()
    {
        _dimmer.Dim(10);
        _dvdPlayer.Pause();
    }

    public void Resume()
    {
        _dimmer.Dim(5);
        _dvdPlayer.Resume();
    }
}
