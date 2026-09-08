// 观察者模式（Observer Pattern）
// 定义对象间的一对多依赖，状态变化时自动通知所有已注册的观察者。

using ObserverPattern.News;
using ObserverPattern.Stock;
using ObserverPattern.Weather;

Console.WriteLine("\n========== 观察者模式 (Observer Pattern) ==========");
Console.WriteLine("定义对象间的一对多依赖，状态变化时通知所有依赖者\n");

// 示例一：气象站
Console.WriteLine("--- 气象站 ---");
var supplier = new WeatherSupplier();
var monitor1 = new WeatherMonitor("温度显示器");
var monitor2 = new WeatherMonitor("湿度显示器");

monitor1.Subscribe(supplier);
supplier.WeatherConditions(32.0, 0.05, 1.5);

monitor2.Subscribe(supplier);
supplier.WeatherConditions(33.5, 0.04, 1.7);

monitor1.Unsubscribe();
supplier.WeatherConditions(37.5, 0.07, 1.2);

// 示例二：股票行情
Console.WriteLine("\n--- 股票行情 ---");
var market = new StockMarket();

var investor1 = new Investor("张三", "AAPL");
var investor2 = new Investor("李四", "TSLA");
var sub1 = market.Subscribe(investor1);
var sub2 = market.Subscribe(investor2);

market.UpdatePrice("AAPL", 182.50);
market.UpdatePrice("TSLA", 245.00);
market.UpdatePrice("GOOG", 172.30);

// 示例三：公众号订阅
Console.WriteLine("\n--- 公众号订阅 ---");
var publisher = new NewsPublisher();

var subscriber1 = new Subscriber("小明");
var subscriber2 = new Subscriber("小红");
var s1 = publisher.Subscribe(subscriber1);
var s2 = publisher.Subscribe(subscriber2);

publisher.Publish("观察者模式详解", "CodeGuide");

s2.Dispose();
publisher.Publish("策略模式实战", "CodeGuide");