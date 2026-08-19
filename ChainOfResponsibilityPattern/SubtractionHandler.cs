namespace ChainOfResponsibilityPattern;

/// <summary>
/// 减法处理器，负责处理 "minus" 类型的请求
/// </summary>
public class SubtractionHandler : BaseHandler
{
    public override double? Handle(double[] values, string action)
    {
        if (string.Equals(action, "minus", StringComparison.OrdinalIgnoreCase))
        {
            var result = values[0];
            for (var i = 1; i < values.Length; i++)
            {
                result -= values[i];
            }
            return result;
        }

        return _nextInLine?.Handle(values, action);
    }
}
