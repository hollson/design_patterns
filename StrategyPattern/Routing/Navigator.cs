namespace StrategyPattern;

/// <summary>
/// 导航上下文：持有路线策略，委托执行
/// </summary>
class Navigator
{
    private IRouteStrategy _strategy;

    public Navigator(IRouteStrategy strategy) => _strategy = strategy;

    public void SetStrategy(IRouteStrategy strategy) => _strategy = strategy;

    public void Navigate(string from, string to, string distance) => _strategy.Navigate(from, to, distance);
}