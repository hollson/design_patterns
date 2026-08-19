namespace ChainOfResponsibilityPattern;

/// <summary>
/// 责任链处理器基类，提供链式调用的基础实现
/// </summary>
public abstract class BaseHandler : IHandler
{
    protected IHandler? _nextInLine;

    public void AddChain(IHandler handler)
    {
        _nextInLine = handler;
    }

    public abstract double? Handle(double[] values, string action);
}
