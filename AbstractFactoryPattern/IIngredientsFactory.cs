// 抽象工厂：配料工厂
public interface IIngredientsFactory
{
    IDough CreateDough();
    ISauce CreateSauce();
    ICheese CreateCheese();
}
