namespace InterpreterPattern;

/// <summary>算术表达式（抽象表达式）：统一求值入口</summary>
public interface IExpression
{
    int Interpret();          // 对表达式求值
}
