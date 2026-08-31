// 职责链模式（Chain of Responsibility Pattern）
// 将请求的发送者和接收者解耦，让多个对象都有机会处理请求。
// 这些对象连接成一条链，并沿着这条链传递请求，直到有一个对象处理它为止。

using ChainOfResponsibilityPattern;

// 创建处理器
var additionHandler = new AdditionHandler();
var subtractionHandler = new SubtractionHandler();
var multiplicationHandler = new MultiplicationHandler();

// 构建责任链：加法 → 减法 → 乘法
subtractionHandler.AddChain(multiplicationHandler);
additionHandler.AddChain(subtractionHandler);

// 执行请求
double[] numbers = [2, 3, 4, 5];
var additionResult = additionHandler.Handle(numbers, "Add");
var subtractionResult = additionHandler.Handle(numbers, "Minus");
var multResult = additionHandler.Handle(numbers, "Multiply");
var divisionResult = additionHandler.Handle(numbers, "divide"); // 除法不在链中，返回 null

Console.WriteLine($"Addition = {additionResult}");
Console.WriteLine($"Subtraction = {subtractionResult}");
Console.WriteLine($"Multiplication = {multResult}");
Console.WriteLine($"Division = {divisionResult}");
