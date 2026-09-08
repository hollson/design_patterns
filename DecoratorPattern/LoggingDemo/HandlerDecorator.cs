namespace DecoratorPattern;

/// <summary>
/// 抽象装饰器：继承抽象组件保持类型一致，持有被装饰处理器引用。
/// </summary>
public abstract class HandlerDecorator(IHandler handler) : IHandler
{
    protected readonly IHandler _handler = handler;

    public abstract void Handle(string request);
}