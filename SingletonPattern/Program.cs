// 单例模式（Singleton Pattern）：确保一个类只有一个实例，并提供全局访问点。
// 本示例演示三种应用：懒汉式延迟初始化（日志记录器）、饿汉式（配置管理器）、生活场景（办公室打印机队列）。

using SingletonPattern;

Console.WriteLine("\n========== 单例模式 (Singleton Pattern) ==========");
Console.WriteLine("确保一个类只有一个实例，并提供全局访问点\n");

// ① 懒汉式 Lazy<T>：日志记录器，首次访问才创建
Console.WriteLine("--- 懒汉式 Lazy<T>: 日志记录器 ---");
Console.WriteLine(">> 准备就绪，日志器尚未创建");

// 4 个线程并发首次访问，Lazy<T> 保证只初始化一次且拿到同一实例
var loggers = new Logger[4];
Parallel.For(0, 4, i => loggers[i] = Logger.Instance);
Console.WriteLine($">> 4 个线程拿到同一实例: {loggers.All(l => ReferenceEquals(l, loggers[0]))}");

Logger.Instance.Info("服务启动");
Logger.Instance.Info("处理用户请求");
Console.WriteLine("\n");

// ② 饿汉式：配置管理器，类加载即创建
Console.WriteLine("--- 饿汉式 静态字段: 配置管理器 ---");
var config = ConfigManager.Instance;
Console.WriteLine($">> db.host = {config.Get("db.host")}");
Console.WriteLine($">> db.port = {config.Get("db.port")}");
Console.WriteLine("\n");

// ③ 生活场景：办公室打印机，多台电脑共享唯一队列
Console.WriteLine("--- 生活场景: 办公室打印机 ---");
PrintSpooler.Instance.Submit("工位A", "季度报表.pdf");
PrintSpooler.Instance.Submit("工位B", "旅行攻略.docx");
PrintSpooler.Instance.Submit("工位C", "发票.xlsx");
PrintSpooler.Instance.PrintAll();
