namespace AbstractFactoryPattern;

/// <summary>SQL Server 命令（具体产品 B2）</summary>
public class SqlServerCommand : ICommand
{
    public void Execute(string sql) => Console.WriteLine($"[SqlServer] 执行：{sql}");
}
