// 工厂方法模式：定义创建对象的接口，由子类决定实例化哪个产品

using FactoryMethodPattern;

Console.WriteLine("========== 工厂方法模式 (Factory Method Pattern) ==========");
Console.WriteLine("让子类决定创建哪个产品，新增产品零修改\n");

Console.WriteLine("--- 经典场景: 跨境物流 ---");
Console.WriteLine(">> 客户端只依赖抽象工厂 Logistics，安排三类运输：\n");

Logistics road = new RoadLogistics();
road.PlanDelivery("2 吨日用百货（上海 → 成都）");

Console.WriteLine();
Logistics sea = new SeaLogistics();
sea.PlanDelivery("800 吨机电设备（青岛 → 洛杉矶）");

Console.WriteLine();
Logistics air = new AirLogistics();
air.PlanDelivery("50kg 疫苗冷链（北京 → 法兰克福）");

Console.WriteLine("\n--- 软件项目: 消息通知中心 ---");
Console.WriteLine(">> 基类固化「创建发送器 → 发送」流程，子类只决定发送器：\n");

NotificationService email = new EmailNotificationService();
email.Notify("alice@example.com", "系统将于今晚 23:00-24:00 维护升级");

Console.WriteLine();
NotificationService sms = new SmsNotificationService();
sms.Notify("138****5678", "您的验证码是 8848，5 分钟内有效");
