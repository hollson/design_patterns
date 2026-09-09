namespace FlyweightPattern;

/// <summary>棋子（享元）：内部状态 = 颜色与外观，全盘共享</summary>
public class GoStone(string color, string material)
{
    public string Color { get; } = color;           // 内部状态：黑白两种，可共享

    public string Material { get; } = material;     // 内部状态：材质纹理，可共享

    /// <summary>落子渲染：位置是外部状态，由调用方传入，不存进棋子</summary>
    public void Place(int x, int y) =>
        Console.WriteLine($"[落子] {Color}子放在 ({x}, {y}) — 材质：{Material}");
}
