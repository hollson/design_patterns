namespace StrategyPattern;

class CreditCard : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine($"信用卡支付 {amount} 元");
    }
}