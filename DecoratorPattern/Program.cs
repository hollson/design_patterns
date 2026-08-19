// 装饰器模式（Decorator Pattern）
// 动态地给对象添加额外职责，比继承更灵活的功能扩展方式。
// 装饰器和被装饰对象具有相同的接口，可以透明地叠加行为。

using DecoratorPattern;

Beverage beverage = new Espresso();
Console.WriteLine(beverage.Description + " $" + beverage.Cost());

Beverage beverage2 = new DarkRoast();
beverage2 = new MochaCondiment(beverage2);
beverage2 = new MochaCondiment(beverage2);
beverage2 = new WhipCondiment(beverage2);
Console.WriteLine(beverage2.Description + " $" + beverage2.Cost());

Beverage beverage3 = new HouseBlend();
beverage3 = new MochaCondiment(beverage3);
beverage3 = new WhipCondiment(beverage3);
Console.WriteLine(beverage3.Description + " $" + beverage3.Cost());
