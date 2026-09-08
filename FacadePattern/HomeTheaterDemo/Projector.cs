namespace FacadePattern;

/// <summary>
/// 投影仪子系统：控制开关与显示模式。
/// </summary>
public class Projector
{
    public void On() => Console.WriteLine("投影仪开机");
    public void WideScreenMode() => Console.WriteLine("投影仪切换宽屏模式");
    public void Off() => Console.WriteLine("投影仪关机");
}