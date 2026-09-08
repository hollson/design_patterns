namespace ProxyPattern;

/// <summary>
/// 真实数据库，直接执行查询。
/// </summary>
public class RealDatabase : IDatabase
{
    public void Query(string sql) => Console.WriteLine("执行查询: " + sql);
}