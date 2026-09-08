namespace StrategyPattern;

class WeChatPay : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"微信支付 {amount} 元");
    }
}