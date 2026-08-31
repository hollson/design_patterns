namespace FactoryPattern
{
    /// <summary>
    /// 披萨抽象基类，定义披萨的通用操作流程
    /// </summary>
    abstract class Pizza
    {
        public string Name { protected get; set; } = null!;

        public string Color = null!;

        internal abstract void Prepare();

        internal void Bake()
        {
            Console.WriteLine("在135摄氏度下烘烤20分钟");
        }

        internal void Cut()
        {
            Console.WriteLine("切成对角块");
        }

        internal void Box()
        {
            Console.WriteLine("将披萨放入" + Color + "色盒子");
        }
    }
}
