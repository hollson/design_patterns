// 中介者模式：用一个中介对象封装一组对象的交互，同事之间互不直接引用

using MediatorPattern;

Console.WriteLine("========== 中介者模式 (Mediator Pattern) ==========");
Console.WriteLine("用一个中介对象封装一组对象的交互\n");

Console.WriteLine("--- 经典场景: 机场控制塔协调起降 ---");
Console.WriteLine(">> 飞机之间互不通话，一切听塔台调度：\n");

var tower = new ControlTower();
var ca1874 = new Airliner("国航 CA1874");
var mu5108 = new Airliner("东航 MU5108");
var cz3456 = new Airliner("南航 CZ3456");

tower.Register(ca1874);
tower.Register(mu5108);
tower.Register(cz3456);
Console.WriteLine();

ca1874.RequestLanding();            // 跑道空闲 → 允许
Console.WriteLine();
mu5108.RequestLanding();            // 跑道被占 → 盘旋等待
Console.WriteLine();
tower.ReleaseRunway(ca1874);        // 国航脱离跑道
mu5108.RequestLanding();            // 再次请求 → 允许

Console.WriteLine("\n--- 软件项目: 群聊聊天室 ---");
Console.WriteLine(">> 用户只把消息发给聊天室，由它广播给其他人：\n");

var room = new ChatRoom();
var alice = new ChatUser("Alice");
var bob = new ChatUser("Bob");
var carol = new ChatUser("Carol");

alice.Join(room);
bob.Join(room);
carol.Join(room);
Console.WriteLine();

alice.Send("今晚一起吃饭吗？");      // 广播给 Bob、Carol
Console.WriteLine();
bob.Send("好啊，老地方见");          // 广播给 Alice、Carol
Console.WriteLine();
carol.Leave();                      // Carol 下线
Console.WriteLine();
carol.Send("我有事，你们去吧");      // 已离线，无人收到
Console.WriteLine("[系统] Carol 已下线，此消息没有送达任何成员");
