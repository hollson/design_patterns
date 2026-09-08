namespace InterpreterPattern;

/// <summary>布尔表达式（抽象表达式）：对上下文求值为真/假</summary>
public interface IBooleanExpression
{
    bool Evaluate(RoleContext context);
}
