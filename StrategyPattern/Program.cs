// 策略模式（Strategy Pattern）—— 运行时替换算法族
// 鸭子的飞行和叫声行为独立变化，通过组合而非继承实现复用

var mallard = new MallardDuck { Quacker = new QuackNormal() };
mallard.Display();
mallard.Flyer = new FlyWings();
mallard.Display();

namespace Ducks
{
    internal class Duck
    {
        private IQuackBehaviour _quacker;
        private IFlyBehaviour _flyer;

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
