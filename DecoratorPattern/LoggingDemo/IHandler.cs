namespace DecoratorPattern;

/// <summary>
/// 抽象组件：请求处理器，定义处理请求的公共契约。
/// </summary>
public interface IHandler
{
    void Handle(string request);
}