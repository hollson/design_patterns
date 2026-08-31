namespace StatePattern;

/// <summary>
/// 无硬币状态——投币后转入 HasQuarterState
/// </summary>
public class NoQuarterState : IState
{
    public GumballMachine Machine { get; }

    public NoQuarterState(GumballMachine machine) => Machine = machine;

    public void InsertQuarter()
    {
        Console.WriteLine("已投入硬币");
        Machine.State = Machine.HasQuarterState;
    }

    public void EjectQuarter() => Console.Write("无法退币");

    public void TurnCrank() => Console.WriteLine("未投币无法转动摇杆");

    public void Dispense() => Console.WriteLine("无法出货");
}
