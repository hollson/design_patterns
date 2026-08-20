// 具体工厂：芝加哥披萨店
public class ChicagoPizzaFactory : IPizzaFactory
{
    public IPizza CreatePizza(string type)
    {
        return type switch
        {
            "clam" => new ChicagoClamPizza(),
            _ => throw new ArgumentException($"未知类型: {type}")
        };
    }
}
