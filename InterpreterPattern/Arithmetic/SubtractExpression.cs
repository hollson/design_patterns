namespace InterpreterPattern;

/// <summary>减法表达式（非终结符表达式）：left - right</summary>
public class SubtractExpression(IExpression left, IExpression right) : IExpression
{
    public int Interpret() => left.Interpret() - right.Interpret();     // 递归解释子式
}
