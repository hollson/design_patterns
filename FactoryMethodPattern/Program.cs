// 工厂方法模式示例：披萨店

Console.WriteLine("\n========== 工厂方法模式 (Factory Method Pattern) ==========");
Console.WriteLine("定义创建对象的接口，让子类决定实例化哪个类\n");

// 纽约披萨店
IPizzaFactory nyFactory = new NyPizzaFactory();
IPizza nyPizza = nyFactory.CreatePizza("cheese");
nyPizza.Prepare();
nyPizza.Bake();
nyPizza.Cut();
nyPizza.Box();
Console.WriteLine();

// 芝加哥披萨店
IPizzaFactory chicagoFactory = new ChicagoPizzaFactory();
IPizza chicagoPizza = chicagoFactory.CreatePizza("clam");
chicagoPizza.Prepare();
chicagoPizza.Bake();
chicagoPizza.Cut();
chicagoPizza.Box();
