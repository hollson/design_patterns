namespace AbstractFactoryPattern;

/// <summary>SQL Server 套件工厂（具体工厂 2）</summary>
public class SqlServerFactory : IDatabaseFactory
{
    public string ProductName => "SQL Server";

    public IConnection CreateConnection() => new SqlServerConnection();

    public ICommand CreateCommand() => new SqlServerCommand();
}
