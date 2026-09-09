namespace AbstractFactoryPattern;

/// <summary>SQL Server 连接（具体产品 A2）</summary>
public class SqlServerConnection : IConnection
{
    public void Open() => Console.WriteLine("[SqlServer] 连接已打开（1433 端口）");

    public void Close() => Console.WriteLine("[SqlServer] 连接已关闭");
}
