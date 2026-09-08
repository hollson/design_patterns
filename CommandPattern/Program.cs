// 命令模式（Command Pattern）：将请求封装为对象，从而解耦调用者与接收者，
// 支持请求的排队、撤销/重做与宏命令组合。
// 本示例演示三种应用：命令排队（餐厅点餐）、撤销与宏命令（智能家居）、撤销/重做（文本编辑器）。

using CommandPattern;

Console.WriteLine("\n========== 命令模式 (Command Pattern) ==========");
Console.WriteLine("将请求封装为对象，支持排队、撤销/重做与宏命令\n");

// ① 命令排队：餐厅点餐
Console.WriteLine("--- 命令排队: 餐厅点餐 ---");
var chef = new Chef();
var waiter = new Waiter();

// 点单只入队，不立即执行
waiter.TakeOrder(new SteakOrder(chef));
waiter.TakeOrder(new NoodleOrder(chef));
waiter.TakeOrder(new SteakOrder(chef));
waiter.SubmitOrders();
Console.WriteLine("\n");

// ② 撤销与宏命令：智能家居遥控器
Console.WriteLine("--- 撤销与宏命令: 智能家居遥控器 ---");
var remote = new RemoteControl(3);
var light = new Light("客厅");
var garage = new Garage("车库");

// 槽位 0：客厅灯，槽位 1：车库门
remote.SetCommand(0, new LightOnCommand(light), new LightOffCommand(light));
remote.SetCommand(1, new GarageDoorOpenCommand(garage), new GarageDoorCloseCommand(garage));

// 槽位 2：宏命令，一键回家 / 一键离家
remote.SetCommand(2,
    new MacroCommand([new GarageDoorOpenCommand(garage), new LightOnCommand(light)]),
    new MacroCommand([new LightOffCommand(light), new GarageDoorCloseCommand(garage)]));

remote.PushOn(0);   // 客厅灯已打开
remote.PushUndo();  // 撤销：客厅灯已关闭
remote.PushUndo();  // 没有可撤销的操作
Console.WriteLine();

remote.PushOn(2);   // 一键回家：开车库门 + 开灯
remote.PushUndo();  // 撤销宏命令：反序 关灯 + 关车库门
Console.WriteLine("\n");

// ③ 撤销/重做：文本编辑器
Console.WriteLine("--- 撤销/重做: 文本编辑器 ---");
var editor = new Editor();
var history = new UndoManager();

Console.WriteLine(">> 输入 Hello");
history.Execute(new TypeTextCommand(editor, "Hello"));
Console.WriteLine(">> 输入 \" World\"");
history.Execute(new TypeTextCommand(editor, " World"));
Console.WriteLine(">> 退格 6 个字符");
history.Execute(new BackspaceCommand(editor, 6));
Console.WriteLine(">> Ctrl+Z 撤销退格");
history.Undo();
Console.WriteLine(">> Ctrl+Z 撤销输入");
history.Undo();
Console.WriteLine(">> Ctrl+Y 重做");
history.Redo();
