// 简单工厂模式：一个工厂类 + 一个 Create 方法，集中管理对象创建

using FactoryPattern;

Console.WriteLine("========== 简单工厂模式 (Simple Factory) ==========");
Console.WriteLine("一个工厂方法集中管理创建，客户端不直接 new 产品\n");

Console.WriteLine("--- 经典场景: 咖啡店点单（switch 表达式版） ---");
Console.WriteLine(">> 顾客依次点单：\n");

foreach (CoffeeType type in Enum.GetValues<CoffeeType>())
    CoffeeFactory.Create(type).Display();

Console.WriteLine("\n>> 顾客点了菜单外的品类：");
try { CoffeeFactory.Create((CoffeeType)99); }
catch (NotSupportedException e) { Console.WriteLine($"[报错] {e.Message}"); }

Console.WriteLine("\n--- 软件项目: 文件解析器（字典注册版） ---");
Console.WriteLine(">> 按扩展名分发到对应解析器：\n");

string json = """{"name":"Alice","age":30}""";
string xml = "<users><user>Alice</user></users>";
string csv = "姓名,年龄\nAlice,30\nBob,25";

(string file, string content)[] files =
[
    ("users.json", json),
    ("config.xml", xml),
    ("books.csv", csv),
];

foreach (var (file, content) in files)
{
    var parser = ParserFactory.GetParser(Path.GetExtension(file));
    Console.WriteLine(parser.Parse(file, content));
}

Console.WriteLine("\n>> 传入不支持的 .txt 文件：");
try { ParserFactory.GetParser(".txt"); }
catch (NotSupportedException e) { Console.WriteLine($"[报错] {e.Message}"); }
