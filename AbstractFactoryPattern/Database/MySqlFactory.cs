namespace AbstractFactoryPattern;

/// <summary>MySQL 套件工厂（具体工厂 1）</summary>
public class MySqlFactory : IDatabaseFactory
{
    public string ProductName => "MySQL";

    public IConnection CreateConnection() => new MySqlConnection();

    public ICommand CreateCommand() => new MySqlCommand();
}
