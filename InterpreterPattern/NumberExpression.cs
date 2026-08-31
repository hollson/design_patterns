// 终结符表达式：数字
public class NumberExpression(int number) : IExpression
{
    private readonly int _number = number;

    public int Interpret() => _number;
}
