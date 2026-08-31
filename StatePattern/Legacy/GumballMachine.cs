// Legacy 版本：所有逻辑集中在一个类中，通过 switch 判断当前状态
// 缺点：每增加一种状态或操作，都需要修改所有 switch 分支，违反开闭原则

namespace StatePattern.Legacy;

/// <summary>
/// 旧式糖果机——状态逻辑与机器耦合，不利于扩展
/// </summary>
public class GumballMachine(int count)
{
    private int _count = count;
    private State _state = State.NoQuarters;

    public void InsertQuarter()
    {
        switch (_state)
        {
            case State.NoQuarters:
                _state = State.HasQuarters;
                Console.WriteLine("已投入硬币");
                break;
            case State.Sold:
                Console.WriteLine("请等待当前糖果出货");
                break;
            case State.HasQuarters:
                Console.WriteLine("不能投入更多硬币");
                break;
            case State.NoGumballs:
                Console.WriteLine("缺货");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void EjectQuarter()
    {
        switch (_state)
        {
            case State.NoQuarters:
                Console.WriteLine("无可退币");
                break;
            case State.Sold:
                Console.WriteLine("抱歉，您已转动摇杆");
                break;
            case State.HasQuarters:
                Console.WriteLine("退币中..");
                _state = State.NoQuarters;
                break;
            case State.NoGumballs:
                Console.WriteLine("无法退币，未接受过硬币");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void TurnCrank()
    {
        switch (_state)
        {
            case State.NoQuarters:
                Console.WriteLine("请先投币");
                break;
            case State.Sold:
                Console.WriteLine("重复转动无法获得糖果");
                break;
            case State.HasQuarters:
                Console.WriteLine("正在出货...");
                _state = State.Sold;
                Dispense();
                break;
            case State.NoGumballs:
                Console.WriteLine("缺货");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void Dispense()
    {
        switch (_state)
        {
            case State.NoQuarters:
                Console.WriteLine("请先投币");
                break;
            case State.Sold:
                Console.WriteLine("一颗糖果滚落出来");
                _count--;
                _state = _count == 0 ? _state = State.NoGumballs : State.NoQuarters;
                break;
            case State.HasQuarters:
            case State.NoGumballs:
                Console.WriteLine("无法出货");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
