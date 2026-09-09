// 抽象工厂模式：创建一族相关对象，无需指定具体类

using AbstractFactoryPattern;

Console.WriteLine("========== 抽象工厂模式 (Abstract Factory Pattern) ==========");
Console.WriteLine("创建一系列相关对象，换工厂 = 换整个产品族\n");

Console.WriteLine("--- 经典场景: 跨平台 UI 主题 ---");
Console.WriteLine(">> 界面代码只依赖抽象工厂，控件全部成套创建：\n");

// 客户端：只写一次"搭界面"的逻辑，主题由注入的工厂决定
static void BuildForm(IWidgetFactory factory)
{
    Console.WriteLine($"--- 切换到 {factory.ThemeName} ---");
    factory.CreateButton().Render();
    factory.CreateTextBox().Render();
    Console.WriteLine();
}

BuildForm(new WindowsFactory());
BuildForm(new MacFactory());

Console.WriteLine("--- 软件项目: 数据库访问套件 ---");
Console.WriteLine(">> 连接与命令必须同族，换数据库只换工厂：\n");

static void RunQuery(IDatabaseFactory factory)
{
    Console.WriteLine($"--- 使用 {factory.ProductName} 套件 ---");
    IConnection connection = factory.CreateConnection();       // 同族连接
    ICommand command = factory.CreateCommand();                // 同族命令
    connection.Open();
    command.Execute("SELECT * FROM orders LIMIT 10");
    connection.Close();
    Console.WriteLine();
}

RunQuery(new MySqlFactory());
RunQuery(new SqlServerFactory());
