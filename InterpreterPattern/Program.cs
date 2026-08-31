// 解释器模式示例：数学表达式求值

Console.WriteLine("\n========== 解释器模式 (Interpreter Pattern) ==========");
Console.WriteLine("给定一个语言，定义它的文法表示，并定义一个解释器\n");

// 构建表达式: (5 + 3) - 2
var expression = new SubtractExpression(
    new AddExpression(
        new NumberExpression(5),
        new NumberExpression(3)
    ),
    new NumberExpression(2)
);

int result = expression.Interpret();
Console.WriteLine($"(5 + 3) - 2 = {result}\n");

// 构建表达式: (10 + 5) - (3 + 2)
var complexExpression = new SubtractExpression(
    new AddExpression(
        new NumberExpression(10),
        new NumberExpression(5)
    ),
    new AddExpression(
        new NumberExpression(3),
        new NumberExpression(2)
    )
);

result = complexExpression.Interpret();
Console.WriteLine($"(10 + 5) - (3 + 2) = {result}");
