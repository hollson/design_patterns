// 工厂模式（Factory Pattern）
// 定义一个创建对象的接口，让子类决定实例化哪一个类。
// 工厂方法将对象的创建延迟到子类。

using FactoryPattern;

Console.WriteLine("\n========== 工厂模式 (Factory Pattern) ==========");
Console.WriteLine("定义创建对象的接口，让子类决定实例化哪个类\n");

var yankees = new NyPizzaFactory();
Console.WriteLine("纽约扬基队球迷的订单：");
yankees.Order(PizzaType.Cheese);
Console.WriteLine();

var cubs = new ChicagoPizzaFactory();
Console.WriteLine("芝加哥小熊队球迷的订单：");
cubs.Order(PizzaType.Clam);
