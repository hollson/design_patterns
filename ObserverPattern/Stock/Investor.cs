namespace ObserverPattern.Stock;

/// <summary>
/// 投资者——观察者，只接收自己关注股票的行情
/// </summary>
sealed class Investor : IObserver<StockPrice>
{
    private readonly string _name;
    private readonly string[] _holdings;

    public Investor(string name, params string[] holdings)
    {
        _name = name;
        _holdings = holdings;
    }

    public void OnNext(StockPrice value)
    {
        if (_holdings.Contains(value.Symbol))
            Console.WriteLine($"{_name} 关注 {value.Symbol}: ¥{value.Price:F2}");
    }

    public void OnError(Exception error) =>
        Console.WriteLine($"{_name} 发生错误: {error.Message}");

    public void OnCompleted() { }
}