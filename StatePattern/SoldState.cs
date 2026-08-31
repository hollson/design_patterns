namespace StatePattern;

/// <summary>
/// 出货状态——释放一颗糖果后转入 NoQuarterState 或 SoldOutState
/// </summary>
public class SoldState : IState
{
    private GumballMachine Machine { get; }

    public SoldState(GumballMachine gumballMachine) => Machine = gumballMachine;

    public void InsertQuarter() => Console.WriteLine("请等待，正在出货");

    public void EjectQuarter() => Console.WriteLine("无法退币，已转动摇杆");

    public void TurnCrank() => Console.WriteLine("重复转动无效");

    public void Dispense()
    {
        Machine.ReleaseBall();
        if (Machine.Count > 0)
        {
            Machine.State = Machine.NoQuarterState;
        }
        else
        {
            Console.WriteLine("糟糕！糖果售罄");
            Machine.State = Machine.SoldOutState;
        }
    }
}
