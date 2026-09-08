namespace FacadePattern;

/// <summary>
/// 幕布子系统：控制升降。
/// </summary>
public class Screen
{
    public void Down() => Console.WriteLine("幕布降下");
    public void Up() => Console.WriteLine("幕布升起");
}