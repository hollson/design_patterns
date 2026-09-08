namespace ProxyPattern;

/// <summary>
/// 数据库接口，定义真实数据库和代理的公共查询操作。
/// </summary>
public interface IDatabase
{
    void Query(string sql);
}