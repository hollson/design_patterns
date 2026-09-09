// 桥接模式：抽象与实现两个维度分离，各自独立扩展

using BridgePattern;

Console.WriteLine("========== 桥接模式 (Bridge Pattern) ==========");
Console.WriteLine("抽象与实现分离，两个维度独立变化\n");

Console.WriteLine("--- 经典场景: 遥控器 × 家电设备 ---");
Console.WriteLine(">> 基础遥控器控制电视：\n");

var tvRemote = new RemoteControl(new Tv());
tvRemote.TogglePower();
tvRemote.VolumeUp();
tvRemote.VolumeUp();

Console.WriteLine("\n>> 高级遥控器控制音响（新增静音键，设备无改动）：\n");

var soundRemote = new AdvancedRemote(new SoundSystem());
soundRemote.TogglePower();
soundRemote.VolumeDown();
soundRemote.Mute();

Console.WriteLine("\n--- 软件项目: 通知类型 × 发送渠道 ---");
Console.WriteLine(">> 普通通知走邮件渠道：\n");

var email = new Notification(new EmailChannel());
email.Notify("alice@example.com", "今晚 22:00 例行系统维护");

Console.WriteLine("\n>> 加急通知走短信渠道（通知与渠道自由组合）：\n");

var urgentSms = new UrgentNotification(new SmsChannel());
urgentSms.NotifyUrgent("138****5678", "线上订单服务不可用，请立即处理");

Console.WriteLine("\n>> 加急通知也可以走邮件渠道：\n");

var urgentEmail = new UrgentNotification(new EmailChannel());
urgentEmail.NotifyUrgent("ops@example.com", "线上订单服务不可用，请立即处理");
