namespace InterpreterPattern;

/// <summary>或表达式（非终结符表达式）：left 或 right</summary>
public class OrExpression(IBooleanExpression left, IBooleanExpression right) : IBooleanExpression
{
    public bool Evaluate(RoleContext context) =>
        left.Evaluate(context) || right.Evaluate(context);      // 递归求值子式
}
