namespace AbstractFactoryPattern;

/// <summary>Mac 风格按钮（具体产品 A2）</summary>
public class MacButton : IButton
{
    public void Render() => Console.WriteLine("[控件] 渲染 Mac 风格按钮：圆角胶囊 + 高斯模糊");
}
