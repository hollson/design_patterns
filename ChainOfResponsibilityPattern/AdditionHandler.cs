namespace ChainOfResponsibilityPattern;

/// <summary>
/// 加法处理器，负责处理 "add" 类型的请求
/// </summary>
public class AdditionHandler : BaseHandler
{
    public override double? Handle(double[] values, string action)
    {
        if (string.Equals(action, "add", StringComparison.OrdinalIgnoreCase))
        {
            return values.Sum();
        }

        return _nextInLine?.Handle(values, action);
    }
}
