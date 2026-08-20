// 具体工厂：纽约披萨店
public class NyPizzaFactory : IPizzaFactory
{
    public IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new NyCheesePizza(),
            _ => throw new ArgumentException($"未知类型: {type}")
        };
    }
}
