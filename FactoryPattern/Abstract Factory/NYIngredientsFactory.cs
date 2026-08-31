namespace FactoryPattern
{
    internal class NyIngredientsFactory : IIngredientsFactory
    {
        ICheese IIngredientsFactory.CreateCheese() => new Mozarella();
        IClam IIngredientsFactory.CreateClam() => new FrozenClam();
        IDough IIngredientsFactory.CreateDough() => new ThinCrust();
        ISauce IIngredientsFactory.CreateSauce() => new CherryTomato();

        IEnumerable<IVeggies> IIngredientsFactory.CreateVeggies() => [new Onion(), new Pepper(), new Olive()];
    }
}
