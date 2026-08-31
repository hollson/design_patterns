namespace FacadePattern;

/// <summary>
/// 调光器，控制灯光亮度开关。
/// </summary>
public class Dimmer
{
    internal void Dim(int val)
    {
        Console.WriteLine(val == 10 ? "打开灯光" : $"将灯光调暗至 {val}");
    }

    internal void Off() => Console.WriteLine("关闭灯光");
}
