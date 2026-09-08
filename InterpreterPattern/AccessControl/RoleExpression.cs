namespace InterpreterPattern;

/// <summary>角色表达式（终结符表达式）：从上下文查询"是否拥有该角色"</summary>
public class RoleExpression(string role) : IBooleanExpression
{
    public bool Evaluate(RoleContext context) => context.HasRole(role);
}
