// 享元模式：内部状态共享 + 外部状态传入，大量细粒度对象不再爆内存

using FlyweightPattern;

Console.WriteLine("========== 享元模式 (Flyweight Pattern) ==========");
Console.WriteLine("共享内部状态，外部状态调用方传入，节省内存\n");

Console.WriteLine("--- 经典场景: 围棋棋子 ---");
Console.WriteLine(">> 一盘棋几百个落子，黑白棋子各只需一个实例：\n");

var stoneFactory = new GoStoneFactory();
var random = new Random(42);                       // 固定种子，输出可复现

// 模拟一盘 300 手的棋
var moves = new (int X, int Y, string Color)[300];
for (int i = 0; i < moves.Length; i++)
{
    string color = i % 2 == 0 ? "黑" : "白";        // 黑先白后交替
    moves[i] = (random.Next(19), random.Next(19), color);
}

int distinctStones = 0;
foreach (var (x, y, color) in moves)
    _ = stoneFactory.GetStone(color);              // 每次落子都从工厂取

distinctStones = stoneFactory.InstanceCount;
Console.WriteLine($">> 全盘 {moves.Length} 手棋落子完毕");
Console.WriteLine($"[统计] 不共享需要 {moves.Length} 个棋子对象；实际只创建了 {distinctStones} 个（黑、白各一）\n");

Console.WriteLine(">> 黑白棋子是同一个实例吗？");
var black1 = stoneFactory.GetStone("黑");
var black2 = stoneFactory.GetStone("黑");
Console.WriteLine($"[验证] ReferenceEquals(black1, black2) = {ReferenceEquals(black1, black2)} —— 同一实例，位置是外部参数");

Console.WriteLine("\n>> 实际落子（位置作为外部状态传入）：");
black1.Place(3, 15);
stoneFactory.GetStone("白").Place(16, 3);

Console.WriteLine("\n--- 软件项目: 富文本编辑器字符样式 ---");
Console.WriteLine(">> 一行文档十几个字符，相同样式共享同一实例：\n");

var styleFactory = new TextStyleFactory();
string line = "Hello, 享元模式!";

Console.WriteLine(">> 逐字符渲染（首次遇到样式才创建）：");
var renders = new List<(char Ch, TextStyle Style)>();
for (int i = 0; i < line.Length; i++)
{
    // 标点用灰色小号，其他统一正文样式
    TextStyle style = char.IsPunctuation(line[i])
        ? styleFactory.GetStyle("微软雅黑", 10, "灰色")
        : styleFactory.GetStyle("微软雅黑", 14, "黑色");
    renders.Add((line[i], style));
    style.Render(line[i], i);
}

Console.WriteLine($"\n>> 渲染 {line.Length} 个字符完毕");
Console.WriteLine($"[统计] 样式实例只有 {styleFactory.InstanceCount} 个（正文 1 + 标点 1），字符各自只存引用");
