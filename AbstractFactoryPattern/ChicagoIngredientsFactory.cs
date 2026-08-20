// 芝加哥配料工厂
public class ChicagoIngredientsFactory : IIngredientsFactory
{
    public IDough CreateDough() => new DeepDish();
    public ISauce CreateSauce() => new PlumTomato();
    public ICheese CreateCheese() => new Parmesan();
}
