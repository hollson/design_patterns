// 解释器模式：文法规则映射为类，组合成表达式树后递归解释

using InterpreterPattern;

Console.WriteLine("========== 解释器模式 (Interpreter Pattern) ==========");
Console.WriteLine("给定一门语言，定义其文法表示与解释器\n");

Console.WriteLine("--- 经典场景: 算术表达式求值 ---");
Console.WriteLine(">> 构建表达式树：(10 + 5) × (8 - 3)");

IExpression expression = new MultiplyExpression(
    new AddExpression(new NumberExpression(10), new NumberExpression(5)),
    new SubtractExpression(new NumberExpression(8), new NumberExpression(3)));
Console.WriteLine($"[求值] (10 + 5) × (8 - 3) = {expression.Interpret()}\n");

Console.WriteLine(">> 整棵树当作子表达式复用，再 +1：");
var plusOne = new AddExpression(expression, new NumberExpression(1));
Console.WriteLine($"[求值] (10 + 5) × (8 - 3) + 1 = {plusOne.Interpret()}");

Console.WriteLine("\n--- 软件项目: 权限规则引擎 ---");
Console.WriteLine(">> 规则：(admin 或 editor) 且 未被封禁\n");

// 规则树只组装一次，可对任意用户上下文反复求值
IBooleanExpression canPublish = new AndExpression(
    new OrExpression(new RoleExpression("admin"), new RoleExpression("editor")),
    new NotExpression(new RoleExpression("banned")));

RoleContext[] users =
[
    new("Alice", ["admin"]),
    new("Bob", ["editor"]),
    new("Eve", ["editor", "banned"]),
];

foreach (var user in users)
{
    Console.WriteLine($">> {user.User}（角色：{user.RolesText}）");
    Console.WriteLine(canPublish.Evaluate(user)
        ? "[通过] 允许发布文章"
        : "[拒绝] 已被封禁，禁止发布");
}
