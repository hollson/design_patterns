namespace FacadePattern;

/// <summary>
/// 功放子系统：控制开关与音量。
/// </summary>
public class Amplifier
{
    public void On() => Console.WriteLine("功放开机");
    public void SetVolume(int level) => Console.WriteLine("音量调至 " + level);
    public void Off() => Console.WriteLine("功放关机");
}