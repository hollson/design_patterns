namespace InterpreterPattern;

/// <summary>数字表达式（终结符表达式）：叶子节点，直接持有字面量</summary>
public class NumberExpression(int value) : IExpression
{
    public int Interpret() => value;     // 终结符：解释在此触底
}
