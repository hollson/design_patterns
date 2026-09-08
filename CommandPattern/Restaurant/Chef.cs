namespace CommandPattern;

/// <summary>
/// 接收者，真正执行烹饪动作的厨师。
/// </summary>
public class Chef
{
    public void CookNoodles() => Console.WriteLine("厨师：一碗牛肉面出锅");

    public void CookSteak() => Console.WriteLine("厨师：一份牛排煎好");
}
