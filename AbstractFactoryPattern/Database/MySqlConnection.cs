namespace AbstractFactoryPattern;

/// <summary>MySQL 连接（具体产品 A1）</summary>
public class MySqlConnection : IConnection
{
    public void Open() => Console.WriteLine("[MySQL] 连接已打开（3306 端口）");

    public void Close() => Console.WriteLine("[MySQL] 连接已关闭");
}
