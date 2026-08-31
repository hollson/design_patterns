namespace FactoryPattern
{
    class CheesePizza : Pizza
    {
        readonly IIngredientsFactory _ingredients;

        public CheesePizza(IIngredientsFactory ing)
        {
            _ingredients = ing;
        }
        internal override void Prepare()
        {
            Console.WriteLine("准备 " + Name + "，使用");
            Console.Write("面团：" + _ingredients.CreateDough().Name + "，奶酪：" + _ingredients.CreateCheese().Name + "，酱料：" + _ingredients.CreateSauce().Name + "，蔬菜：");
            Console.WriteLine();
            foreach (var val in _ingredients.CreateVeggies())
            {
                Console.Write(val.Name + " ");
            }
            Console.WriteLine();
        }
    }
}
