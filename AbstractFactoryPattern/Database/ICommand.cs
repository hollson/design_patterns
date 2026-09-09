namespace AbstractFactoryPattern;

/// <summary>数据库命令（抽象产品 B）：套件族中的另一员</summary>
public interface ICommand
{
    void Execute(string sql);       // 执行 SQL
}
