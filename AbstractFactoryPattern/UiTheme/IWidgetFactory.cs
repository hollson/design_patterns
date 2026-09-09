namespace AbstractFactoryPattern;

/// <summary>控件工厂（抽象工厂）：一次创建一族控件，保证风格统一</summary>
public interface IWidgetFactory
{
    string ThemeName { get; }         // 主题名

    IButton CreateButton();           // 创建本族按钮

    ITextBox CreateTextBox();         // 创建本族输入框
}
