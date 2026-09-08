namespace SingletonPattern;

/// <summary>
/// 配置管理器单例，饿汉式：静态字段在类加载时立即创建，
/// CLR 保证静态初始化的线程安全，无需手动加锁。
/// </summary>
public class ConfigManager
{
    // 饿汉式：类加载即创建，天生线程安全
    private static readonly ConfigManager _instance = new();

    public static ConfigManager Instance => _instance;

    private readonly Dictionary<string, string> _settings;

    private ConfigManager()
    {
        Console.WriteLine("[初始化] 从 appsettings.json 加载配置（类加载时执行）");
        _settings = new Dictionary<string, string>
        {
            ["db.host"] = "localhost",
            ["db.port"] = "5432"
        };
    }

    public string Get(string key) => _settings.GetValueOrDefault(key, "(未配置)");
}
