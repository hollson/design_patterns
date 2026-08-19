namespace ChainOfResponsibilityPattern;

/// <summary>
/// 职责链处理器接口，定义请求处理和链式传递的契约
/// </summary>
public interface IHandler
{
    /// <summary>
    /// 将下一个处理器添加到责任链中
    /// </summary>
    void AddChain(IHandler handler);

    /// <summary>
    /// 处理请求，返回计算结果；若当前处理器无法处理则传递给链中下一个处理器
    /// </summary>
    double? Handle(double[] values, string action);
}
