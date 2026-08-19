// 观察者模式：定义对象间的一对多依赖关系，当一个对象状态改变时，所有依赖者自动收到通知。
// 天气供应者作为被观察者，气象站作为观察者订阅天气变化并更新显示。

var provider = new WeatherSupplier();
var observer1 = new WeatherMonitor("TP");
var observer2 = new WeatherMonitor("H");
provider.WeatherConditions(32.0, 0.05, 1.5);
observer1.Subscribe(provider);
provider.WeatherConditions(33.5, 0.04, 1.7);
observer2.Subscribe(provider);
provider.WeatherConditions(37.5, 0.07, 1.2);
