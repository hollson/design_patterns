namespace ProxyPattern;

/// <summary>
/// 保护代理，执行查询前校验用户是否已登录。
/// </summary>
public class AuthDatabaseProxy : IDatabase
{
    private readonly RealDatabase _real = new RealDatabase();
    private readonly bool _loggedIn;

    public AuthDatabaseProxy(bool loggedIn) => _loggedIn = loggedIn;

    public void Query(string sql)
    {
        if (!_loggedIn)
        {
            Console.WriteLine("拒绝查询: 未登录，无权访问数据库");
            return;
        }
        _real.Query(sql);
    }
}