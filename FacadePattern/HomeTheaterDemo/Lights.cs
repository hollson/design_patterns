namespace FacadePattern;

/// <summary>
/// 灯光子系统：控制亮度。
/// </summary>
public class Lights
{
    public void Dim(int level) => Console.WriteLine("灯光调暗至 " + level + "%");
    public void On() => Console.WriteLine("灯光全亮");
}