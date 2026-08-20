// 抽象产品：酱料
public interface ISauce
{
    string Name { get; }
}

public class CherryTomato : ISauce
{
    public string Name => "樱桃番茄酱";
}

public class PlumTomato : ISauce
{
    public string Name => "李子番茄酱";
}
