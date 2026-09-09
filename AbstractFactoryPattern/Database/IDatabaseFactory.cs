namespace AbstractFactoryPattern;

/// <summary>数据库套件工厂（抽象工厂）：连接与命令必须来自同一数据库</summary>
public interface IDatabaseFactory
{
    string ProductName { get; }             // 数据库名

    IConnection CreateConnection();         // 创建本族连接

    ICommand CreateCommand();               // 创建本族命令
}
