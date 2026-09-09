namespace AbstractFactoryPattern;

/// <summary>Windows 风格按钮（具体产品 A1）</summary>
public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("[控件] 渲染 Windows 风格按钮：方正边框 + 系统蓝");
}
