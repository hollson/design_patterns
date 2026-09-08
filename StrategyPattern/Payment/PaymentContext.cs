namespace StrategyPattern;

/// <summary>
/// 支付上下文：持有支付策略，委托执行
/// </summary>
class PaymentContext
{
    private IPaymentStrategy _strategy;

    public PaymentContext(IPaymentStrategy strategy) => _strategy = strategy;

    public void SetStrategy(IPaymentStrategy strategy) => _strategy = strategy;

    public void Pay(int amount) => _strategy.Pay(amount);
}