// 装饰器模式（Decorator Pattern）：动态地为对象添加额外职责，比继承更灵活。
// 装饰器与被装饰对象保持相同的抽象类型，可层层叠加、对客户端透明。

using DecoratorPattern;

Console.WriteLine("\n========== 装饰器模式 (Decorator Pattern) ==========");
Console.WriteLine("动态地给对象添加额外的职责，比生成子类更灵活\n");

// ========== ① 机器人穿戴 ==========
Console.WriteLine("--- 机器人穿戴 (Robot Demo) ---");

Robot bare = new BaseRobot();
Console.WriteLine(bare.Description + " 战斗力: " + bare.Power());
Console.WriteLine("");

Robot knight = new BaseRobot();
knight = new Helmet(knight);
knight = new Armor(knight);
knight = new Sword(knight);
Console.WriteLine(knight.Description + " 战斗力: " + knight.Power());
Console.WriteLine("");

Robot scout = new BaseRobot();
scout = new Helmet(scout);
scout = new Sword(scout);
Console.WriteLine(scout.Description + " 战斗力: " + scout.Power());
Console.WriteLine("\n");

// ========== ② API 埋点日志 ==========
Console.WriteLine("--- API 埋点日志 (Logging Demo) ---");

IHandler raw = new OrderHandler();
raw.Handle("order-123");
Console.WriteLine("");

IHandler logged = new LoggingHandler(new OrderHandler());
logged.Handle("order-456");
Console.WriteLine("");

IHandler doubleLogged = new LoggingHandler(new LoggingHandler(new OrderHandler()));
doubleLogged.Handle("order-789");