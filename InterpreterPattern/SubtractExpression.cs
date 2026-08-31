// 非终结符表达式：减法
public class SubtractExpression(IExpression left, IExpression right) : IExpression
{
    private readonly IExpression _left = left;
    private readonly IExpression _right = right;

    public int Interpret() => _left.Interpret() - _right.Interpret();
}
