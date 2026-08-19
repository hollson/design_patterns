namespace ChainOfResponsibilityPattern;

/// <summary>
/// 乘法处理器，负责处理 "multiply" 类型的请求
/// </summary>
public class MultiplicationHandler : BaseHandler
{
    public override double? Handle(double[] values, string action)
    {
        if (string.Equals(action, "multiply", StringComparison.OrdinalIgnoreCase))
        {
            return values.Aggregate(1.0, (acc, v) => acc * v);
        }

        return _nextInLine?.Handle(values, action);
    }
}
