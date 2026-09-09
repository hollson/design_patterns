namespace AbstractFactoryPattern;

/// <summary>MySQL 命令（具体产品 B1）</summary>
public class MySqlCommand : ICommand
{
    public void Execute(string sql) => Console.WriteLine($"[MySQL] 执行：{sql}");
}
