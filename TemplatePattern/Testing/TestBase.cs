namespace TemplatePattern;

/// <summary>测试基类（抽象类）：Run() 固化测试生命周期骨架，与 xUnit/NUnit 同构</summary>
public abstract class TestBase(string testName)
{
    public string TestName { get; } = testName;

    /// <summary>模板方法：Setup → Test → TearDown，顺序永不变</summary>
    public void Run()
    {
        Console.WriteLine($">> 运行 {TestName}");
        try
        {
            Setup();                        // 前置：准备环境（子类可选覆写）
            Test();                         // 用例：子类必须实现
            Console.WriteLine("[通过] 测试通过");
        }
        catch (Exception e)
        {
            Console.WriteLine($"[失败] 断言失败：{e.Message}");
        }
        finally
        {
            TearDown();                     // 后置：无论如何都清理
        }
    }

    /// <summary>前置钩子：默认空实现，子类按需覆写</summary>
    protected virtual void Setup() { }

    /// <summary>测试步骤：唯一必填的变化点</summary>
    protected abstract void Test();

    /// <summary>后置钩子：默认空实现，子类按需覆写</summary>
    protected virtual void TearDown() { }
}
