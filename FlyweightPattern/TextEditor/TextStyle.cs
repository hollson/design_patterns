namespace FlyweightPattern;

/// <summary>字符样式（享元）：字体+字号+颜色是内部状态，同款样式全文档共享一个实例</summary>
public class TextStyle(string font, int size, string color)
{
    public string Font { get; } = font;

    public int Size { get; } = size;

    public string Color { get; } = color;

    /// <summary>渲染字符：字符与位置是外部状态，调用方传入</summary>
    public void Render(char ch, int index) =>
        Console.WriteLine($"  [{index}] '{ch}' ← {Font} {Size}pt {Color}");
}
