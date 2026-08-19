namespace FacadePattern;

/// <summary>
/// 调光器，控制灯光亮度开关。
/// </summary>
public class Dimmer
{
    internal void Dim(int val)
    {
        Console.WriteLine(val == 10 ? "Turning Lights On" : $"Dimming lights to {val}");
    }

    internal void Off() => Console.WriteLine("Switching off lights");
}
