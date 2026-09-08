namespace StrategyPattern;

class Bicycle : IRouteStrategy
{
    public void Navigate(string from, string to, string distance)
    {
        Console.WriteLine($"骑行：{from} → {to}（{distance}），预计15分钟");
    }
}