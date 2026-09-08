// 代理模式（Proxy Pattern）：为目标对象提供一个代理以控制对它的访问，
// 代理对象与目标对象实现相同接口，可在访问目标前后添加额外逻辑（如延迟加载、权限校验、远程调用）。
// 本示例演示三种代理：虚拟代理、远程代理、保护代理。

using ProxyPattern;

Console.WriteLine("\n========== 代理模式 (Proxy Pattern) ==========");
Console.WriteLine("为其他对象提供代理以控制对这个对象的访问\n");

// ① 虚拟代理：图片延迟加载
Console.WriteLine("--- 虚拟代理 (Virtual Proxy) ---");
Image image = new ProxyImage("photo.jpg");

// 图片将从磁盘加载
image.display();
Console.WriteLine("");

// 图片不会重复从磁盘加载
image.display();
Console.WriteLine("\n");

// ② 远程代理：酒店预订（模拟网络往返）
Console.WriteLine("--- 远程代理 (Remote Proxy) ---");
IHotel hotel = new HotelProxy();
hotel.Book("海景双人房");
Console.WriteLine("\n");

// ③ 保护代理：数据库权限校验
Console.WriteLine("--- 保护代理 (Protective Proxy) ---");
IDatabase admin = new AuthDatabaseProxy(loggedIn: true);
IDatabase guest = new AuthDatabaseProxy(loggedIn: false);

admin.Query("SELECT * FROM users");   // 已登录，允许
guest.Query("SELECT * FROM users");  // 未登录，拒绝