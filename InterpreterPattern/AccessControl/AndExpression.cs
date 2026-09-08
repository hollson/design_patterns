namespace InterpreterPattern;

/// <summary>与表达式（非终结符表达式）：left 且 right</summary>
public class AndExpression(IBooleanExpression left, IBooleanExpression right) : IBooleanExpression
{
    public bool Evaluate(RoleContext context) =>
        left.Evaluate(context) && right.Evaluate(context);      // 递归求值子式
}
