namespace FacadePattern;

/// <summary>
/// 家庭影院外观：封装投影仪、功放、灯光、幕布的复杂协作，对外提供一键观影。
/// </summary>
public class HomeTheaterFacade
{
    private readonly Projector _projector = new();
    private readonly Amplifier _amp = new();
    private readonly Lights _lights = new();
    private readonly Screen _screen = new();

    /// <summary>
    /// 一键观影：按正确顺序协调所有子系统。
    /// </summary>
    public void WatchMovie(string movie)
    {
        _lights.Dim(10);
        _screen.Down();
        _projector.On();
        _projector.WideScreenMode();
        _amp.On();
        _amp.SetVolume(5);
        Console.WriteLine("正在播放: " + movie);
    }

    /// <summary>
    /// 结束观影：按相反顺序关闭所有子系统。
    /// </summary>
    public void EndMovie()
    {
        _amp.Off();
        _projector.Off();
        _screen.Up();
        _lights.On();
        Console.WriteLine("观影结束");
    }
}