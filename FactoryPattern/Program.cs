// 工厂模式（Factory Pattern）
// 定义一个创建对象的接口，让子类决定实例化哪一个类。
// 工厂方法将对象的创建延迟到子类。

using FactoryPattern;

var yankees = new NyPizzaFactory();
Console.WriteLine("Yankees fan orders:");
yankees.Order(PizzaType.Cheese);
Console.WriteLine();

var cubs = new ChicagoPizzaFactory();
Console.WriteLine("Cubs fan orders:");
cubs.Order(PizzaType.Clam);
