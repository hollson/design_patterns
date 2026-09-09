// 模板方法模式：基类固化算法骨架，子类只实现变化步骤

using TemplatePattern;

Console.WriteLine("========== 模板方法模式 (Template Method) ==========");
Console.WriteLine("定义算法骨架，步骤实现延迟到子类\n");

Console.WriteLine("--- 经典场景: 茶与咖啡的冲泡流程 ---");
Console.WriteLine(">> 同一套「烧水→冲泡→倒杯→加料」骨架，茶咖啡各自实现：\n");

Beverage tea = new Tea();
tea.Prepare();

Console.WriteLine();
Beverage coffee = new Coffee();
coffee.Prepare();          // 钩子关闭：这杯不加料

Console.WriteLine("\n--- 软件项目: 单元测试框架生命周期 ---");
Console.WriteLine(">> Setup → Test → TearDown 骨架固定，用例只写测试步骤（xUnit 同构）：\n");

TestBase[] tests = [new LoginTest(), new InventoryTest()];
foreach (var test in tests)
{
    test.Run();
    Console.WriteLine();
}
