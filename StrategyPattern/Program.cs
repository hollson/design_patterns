// 策略模式（Strategy Pattern）—— 运行时替换算法族
// 鸭子的飞行和叫声行为独立变化，通过组合而非继承实现复用

using Ducks;

Console.WriteLine("\n========== 策略模式 (Strategy Pattern) ==========");
Console.WriteLine("定义一系列算法，将每一个封装起来，并使它们可互相替换\n");

var mallard = new MallardDuck { Quacker = new QuackNormal() };
mallard.Display();
mallard.Flyer = new FlyWings();
mallard.Display();

namespace Ducks
{
    internal class Duck
    {
        private IQuackBehaviour _quacker = null!;
        private IFlyBehaviour _flyer = null!;

        public IQuackBehaviour Quacker
        {
            set
            {
                _quacker = value;
            }
        }

        public IFlyBehaviour Flyer
        {
            set
            {
                _flyer = value;
            }
        }

        protected void PerformQuack()
        {
            _quacker.Quack();
        }

        protected void PerformFly()
        {
            _flyer.Fly();
        }
    }

    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Flyer = new FlyNope();
            Quacker = new QuackNope();
        }

        public void Display()
        {
            PerformFly();
            PerformQuack();
        }
    }
}
