namespace FlyweightPattern;

/// <summary>样式工厂：样式键 → 共享实例（浏览器 DevTools 里常见的 style interning）</summary>
public class TextStyleFactory
{
    private readonly Dictionary<string, TextStyle> _styles = [];    // 共享池

    public int InstanceCount => _styles.Count;                     // 已创建实例数

    /// <summary>取样式：相同的 (字体, 字号, 颜色) 组合永远返回同一实例</summary>
    public TextStyle GetStyle(string font, int size, string color)
    {
        string key = $"{font}|{size}|{color}";                      // 内部状态组合成键
        if (!_styles.TryGetValue(key, out var style))
        {
            style = new TextStyle(font, size, color);
            _styles[key] = style;
            Console.WriteLine($"[创建] 新样式实例：{font} {size}pt {color}（池中第 {_styles.Count} 个）");
        }
        return style;
    }
}
