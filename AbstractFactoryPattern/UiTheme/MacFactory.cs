namespace AbstractFactoryPattern;

/// <summary>Mac 主题工厂（具体工厂 2）：只出 Mac 族控件</summary>
public class MacFactory : IWidgetFactory
{
    public string ThemeName => "Mac 主题";

    public IButton CreateButton() => new MacButton();

    public ITextBox CreateTextBox() => new MacTextBox();
}
