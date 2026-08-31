namespace StatePattern;

/// <summary>
/// 中奖状态——免费多出一颗糖果
/// </summary>
public class WinnerState : IState
{
    private GumballMachine Machine { get; }

    public WinnerState(GumballMachine gumballMachine) => Machine = gumballMachine;

    public void InsertQuarter() => Console.WriteLine("请等待，正在出货");

    public void EjectQuarter() => Console.WriteLine("无法退币，已转动摇杆");

    public void TurnCrank() => Console.WriteLine("重复转动无效");


    public void Dispense()
    {
        Console.WriteLine("中奖了！买一送一");
        Machine.ReleaseBall();
        if (Machine.Count == 0)
        {
            Machine.State = Machine.SoldOutState;
            Console.WriteLine("糟糕！糖果售罄");
        }
        else
        {
            Machine.ReleaseBall();
            Machine.State = Machine.NoQuarterState;
        }
    }
}
