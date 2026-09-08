namespace StrategyPattern;

/// <summary>
/// 支付策略接口
/// </summary>
interface IPaymentStrategy
{
    void Pay(int amount);
}