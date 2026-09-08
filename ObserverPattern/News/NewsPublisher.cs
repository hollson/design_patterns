namespace ObserverPattern.News;

/// <summary>
/// 公众号——被观察者，发布文章时推送所有订阅者
/// </summary>
class NewsPublisher : IObservable<NewsArticle>
{
    private readonly List<IObserver<NewsArticle>> _observers = [];

    public IDisposable Subscribe(IObserver<NewsArticle> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
        return new Unsubscriber<NewsArticle>(_observers, observer);
    }

    /// <summary>
    /// 发布新文章，通知所有订阅者
    /// </summary>
    public void Publish(string title, string author)
    {
        var article = new NewsArticle(title, author);
        foreach (var observer in _observers)
            observer.OnNext(article);
    }
}