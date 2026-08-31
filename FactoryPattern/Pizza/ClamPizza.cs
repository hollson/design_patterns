namespace FactoryPattern
{
    class ClamPizza : Pizza
    {
        readonly IIngredientsFactory _ingredients;

        public ClamPizza(IIngredientsFactory ing)
        {
            _ingredients = ing;
        }

        internal override void Prepare()
        {
            Console.WriteLine("准备 " + Name + "，使用");
            Console.Write("面团：" + _ingredients.CreateDough().Name + "，蛤蜊：" + _ingredients.CreateClam().Name + "，酱料：" + _ingredients.CreateSauce().Name + "，奶酪：" + _ingredients.CreateCheese().Name);
            Console.WriteLine();

        }
    }
}
