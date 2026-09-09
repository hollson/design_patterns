// 备忘录模式：不破坏封装的前提下，捕获并外部保存对象内部状态

using MementoPattern;

Console.WriteLine("========== 备忘录模式 (Memento Pattern) ==========");
Console.WriteLine("捕获对象内部状态，以便以后恢复\n");

Console.WriteLine("--- 经典场景: 游戏角色存档 ---");
Console.WriteLine(">> 打 Boss 前存档，打输了读档重来：\n");

var player = new GameCharacter(level: 8, health: 100, posX: 20, posY: 35);
var saves = new SaveManager();

player.Show();

Console.WriteLine("\n>> 战前存档：");
saves.Save("打Boss前", player.CreateSnapshot());

Console.WriteLine("\n>> 开始战斗：");
player.TakeDamage(45);
player.LevelUp();
player.MoveForward();
player.Show();

Console.WriteLine("\n>> 买张回城票再存一档：");
saves.Save("回城点", player.CreateSnapshot());

Console.WriteLine("\n>> 不小心被团灭：");
player.TakeDamage(999);
player.Show();

Console.WriteLine("\n>> 读取「打Boss前」存档：");
player.Restore(saves.Load("打Boss前"));
player.Show();

Console.WriteLine("\n--- 软件项目: 银行转账事务回滚 ---");
Console.WriteLine(">> 转账两步操作，第二步失败则回滚第一步：\n");

var alice = new Account("Alice", 1000m);
var bob = new Account("Bob", 500m, depositLimit: 1000m);      // Bob 有单笔入账风控限额
alice.Show();
bob.Show();

Console.WriteLine();
Console.WriteLine(">> 情形一：¥300 未超限额，两步都成功：");
TransferService.Transfer(alice, bob, 300m);

Console.WriteLine();
var carol = new Account("Carol", 5000m);
Console.WriteLine(">> 情形二：Carol 转 Bob ¥2000 —— Carol 扣款成功，Bob 入账超限失败：");
carol.Show();
Console.WriteLine();
TransferService.Transfer(carol, bob, 2000m);
carol.Show();                                                 // 回滚生效：仍是 5000
