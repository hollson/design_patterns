namespace StrategyPattern;

class Alipay : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"支付宝支付 {amount} 元");
    }
}