namespace AbstractFactoryPattern;

/// <summary>Windows 风格输入框（具体产品 B1）</summary>
public class WindowsTextBox : ITextBox
{
    public void Render() => Console.WriteLine("[控件] 渲染 Windows 风格输入框：单线边框 + 系统字体");
}
