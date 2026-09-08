namespace StrategyPattern;

class HighSpeedRail : IRouteStrategy
{
    public void Navigate(string from, string to, string distance)
    {
        Console.WriteLine($"高铁：{from} → {to}（{distance}），预计4.5小时");
    }
}