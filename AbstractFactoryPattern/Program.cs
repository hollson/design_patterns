// 抽象工厂模式示例：披萨配料工厂

Console.WriteLine("\n========== 抽象工厂模式 (Abstract Factory Pattern) ==========");
Console.WriteLine("提供一个创建一系列相关或相互依赖对象的接口\n");

// 纽约风味配料
IIngredientsFactory nyFactory = new NyIngredientsFactory();
IDough nyDough = nyFactory.CreateDough();
ISauce nySauce = nyFactory.CreateSauce();
ICheese nyCheese = nyFactory.CreateCheese();
Console.WriteLine($"纽约风味: {nyDough.Name} + {nySauce.Name} + {nyCheese.Name}\n");

// 芝加哥风味配料
IIngredientsFactory chicagoFactory = new ChicagoIngredientsFactory();
IDough chicagoDough = chicagoFactory.CreateDough();
ISauce chicagoSauce = chicagoFactory.CreateSauce();
ICheese chicagoCheese = chicagoFactory.CreateCheese();
Console.WriteLine($"芝加哥风味: {chicagoDough.Name} + {chicagoSauce.Name} + {chicagoCheese.Name}");
