namespace ObserverPattern.Stock;

/// <summary>
/// 股票行情中心——被观察者，价格变动时推送所有订阅者
/// </summary>
class StockMarket : IObservable<StockPrice>
{
    private readonly List<IObserver<StockPrice>> _observers = [];

    public IDisposable Subscribe(IObserver<StockPrice> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
        return new Unsubscriber<StockPrice>(_observers, observer);
    }

    /// <summary>
    /// 产生新行情，通知所有投资者
    /// </summary>
    public void UpdatePrice(string symbol, double price)
    {
        var stock = new StockPrice(symbol, price);
        foreach (var observer in _observers)
            observer.OnNext(stock);
    }
}