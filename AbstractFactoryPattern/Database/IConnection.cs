namespace AbstractFactoryPattern;

/// <summary>数据库连接（抽象产品 A）：套件族中的一员</summary>
public interface IConnection
{
    void Open();            // 打开连接

    void Close();           // 关闭连接
}
