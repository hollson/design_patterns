namespace AbstractFactoryPattern;

/// <summary>Windows 主题工厂（具体工厂 1）：只出 Windows 族控件</summary>
public class WindowsFactory : IWidgetFactory
{
    public string ThemeName => "Windows 主题";

    public IButton CreateButton() => new WindowsButton();

    public ITextBox CreateTextBox() => new WindowsTextBox();
}
