namespace FactoryPattern
{
    /// <summary>
    /// 披萨抽象基类，定义披萨的通用操作流程
    /// </summary>
    abstract class Pizza
    {
        public string Name { protected get; set; }

        public string Color;

        internal abstract void Prepare();

        internal void Bake()
        {
            Console.WriteLine("Baking at 135 degree Celsius for 20 minutes");
        }

        internal void Cut()
        {
            Console.WriteLine("Cutting into diagonal pieces");
        }

        internal void Box()
        {
            Console.WriteLine("Putting pizza in " + Color + " coloured box");
        }
    }
}
