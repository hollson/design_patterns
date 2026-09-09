namespace AbstractFactoryPattern;

/// <summary>Mac 风格输入框（具体产品 B2）</summary>
public class MacTextBox : ITextBox
{
    public void Render() => Console.WriteLine("[控件] 渲染 Mac 风格输入框：无边框 + 聚焦光环");
}
