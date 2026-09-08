namespace StatePattern;

/// <summary>
/// 已投币状态：转动摇杆切换到出货状态，退币回到未投币状态。
/// </summary>
public class HasQuarterState(GumballMachine machine) : IState
{
    public void InsertQuarter() => Console.WriteLine("[拒绝] 不能投入更多硬币");

    public void EjectQuarter()
    {
        Console.WriteLine("[退币] 硬币已退回");
        machine.State = machine.NoQuarter;
    }

    public void TurnCrank()
    {
        Console.WriteLine("[转动] 摇杆转动中");
        machine.State = machine.Sold;
    }

    public void Dispense() => Console.WriteLine("[拒绝] 需先转动摇杆");
}
