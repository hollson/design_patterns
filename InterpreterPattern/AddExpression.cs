// 非终结符表达式：加法
public class AddExpression(IExpression left, IExpression right) : IExpression
{
    private readonly IExpression _left = left;
    private readonly IExpression _right = right;

    public int Interpret() => _left.Interpret() + _right.Interpret();
}
