namespace StrategyPattern;

/// <summary>
/// 路线策略接口
/// </summary>
interface IRouteStrategy
{
    void Navigate(string from, string to, string distance);
}