namespace FactoryPattern
{
    internal class ChicagoIngredientsFactory : IIngredientsFactory
    {
        ICheese IIngredientsFactory.CreateCheese() => new Parmesan();
        IClam IIngredientsFactory.CreateClam() => new FreshClam();
        IDough IIngredientsFactory.CreateDough() => new DeepDish();
        ISauce IIngredientsFactory.CreateSauce() => new PlumTomato();

        IEnumerable<IVeggies> IIngredientsFactory.CreateVeggies() => [new Onion(), new Cucumber(), new Pepper()];
    }
}
