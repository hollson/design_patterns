// 抽象产品：奶酪
public interface ICheese
{
    string Name { get; }
}

public class Mozarella : ICheese
{
    public string Name => "马苏里拉";
}

public class Parmesan : ICheese
{
    public string Name => "帕尔马干酪";
}
