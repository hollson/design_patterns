// 适配器模式：把一个类的接口转换成客户端期望的另一个接口

using AdapterPattern;

Console.WriteLine("========== 适配器模式 (Adapter Pattern) ==========");
Console.WriteLine("转换接口，让原本不兼容的类协同工作\n");

Console.WriteLine("--- 经典场景: 旅行电源转换头（对象适配器） ---\n");

// 客户端代码只认国标插座接口
static void UseSocket(IStdSocket socket) => socket.PowerOn();

var hairDryer = new BritishPlug("港版吹风机");
Console.WriteLine(">> 把港版吹风机（英标三脚插头）插进国标插座：");
Console.WriteLine("[失败] 插头形状不匹配，插不进去（接口不兼容，编译都过不了）");

Console.WriteLine("\n>> 插上旅行转换头再试：");
IStdSocket adapter = new TravelAdapter(hairDryer);
UseSocket(adapter);          // 客户端无感知，照常供电

Console.WriteLine("\n--- 软件项目: 统一支付网关（对象适配器） ---");
Console.WriteLine(">> 收银台只认 IPaymentGateway，两家 SDK 接口各不相同：\n");

IPaymentGateway wechat = new WeChatPayAdapter(new WeChatPaySdk());
IPaymentGateway alipay = new AlipayAdapter(new AlipaySdk());

Console.WriteLine(">> 用微信支付 199.50 元：");
wechat.Pay("WX-2024-001", 199.50m);

Console.WriteLine("\n>> 用支付宝支付 88 元：");
alipay.Pay("ALI-2024-002", 88m);

Console.WriteLine("\n>> 微信退款 199.50 元：");
wechat.Refund("WX-2024-001", 199.50m);
