namespace ObserverPattern.News;

/// <summary>
/// 订阅用户——观察者，接收新文章推送
/// </summary>
sealed class Subscriber : IObserver<NewsArticle>
{
    private readonly string _name;

    public Subscriber(string name) => _name = name;

    public void OnNext(NewsArticle value) =>
        Console.WriteLine($"{_name} 收到推送：《{value.Title}》作者 {value.Author}");

    public void OnError(Exception error) =>
        Console.WriteLine($"{_name} 发生错误: {error.Message}");

    public void OnCompleted() { }
}