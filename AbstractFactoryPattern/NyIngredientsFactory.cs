// 纽约配料工厂
public class NyIngredientsFactory : IIngredientsFactory
{
    public IDough CreateDough() => new ThinCrust();
    public ISauce CreateSauce() => new CherryTomato();
    public ICheese CreateCheese() => new Mozarella();
}
