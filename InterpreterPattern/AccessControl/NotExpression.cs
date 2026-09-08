namespace InterpreterPattern;

/// <summary>非表达式（非终结符表达式）：not inner</summary>
public class NotExpression(IBooleanExpression inner) : IBooleanExpression
{
    public bool Evaluate(RoleContext context) => !inner.Evaluate(context);
}
