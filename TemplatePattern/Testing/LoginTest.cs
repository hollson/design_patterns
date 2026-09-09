namespace TemplatePattern;

/// <summary>登录测试（具体类）：只写测试步骤，生命周期交给基类</summary>
public class LoginTest() : TestBase("登录测试")
{
    private string _token = null!;

    protected override void Setup() => Console.WriteLine("[Setup] 启动浏览器，打开登录页");

    protected override void Test()
    {
        Console.WriteLine("[Test] 输入账号密码并提交");
        _token = "jwt-abc123";                                   // 模拟登录成功
        if (_token is null) throw new Exception("未拿到 token");
        Console.WriteLine("[Test] 校验 token 已签发");
    }

    protected override void TearDown() => Console.WriteLine("[Teardown] 关闭浏览器，清理会话");
}
