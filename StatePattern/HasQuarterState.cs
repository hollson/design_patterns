namespace StatePattern;

/// <summary>
/// 有硬币状态——转动摇杆后可能中奖或正常出货
/// </summary>
public class HasQuarterState : IState
{
    private GumballMachine Machine { get; }
    readonly Random _random = Random.Shared;

    public HasQuarterState(GumballMachine gumballMachine) => Machine = gumballMachine;

    public void InsertQuarter() => Console.WriteLine("不能投入更多硬币");

    public void EjectQuarter()
    {
        Console.WriteLine("硬币已退回");
        Machine.State = Machine.NoQuarterState;
    }

    public void TurnCrank()
    {
        Console.WriteLine("您转动了摇杆");
        var winner = _random.Next(10);
        if ((winner == 5) && (Machine.Count > 1))
            Machine.State = Machine.WinnerState;
        else
        {
            Machine.State = Machine.SoldState;
        }
    }

    public void Dispense()
    {
        Console.WriteLine("无法执行此操作");
    }
}
