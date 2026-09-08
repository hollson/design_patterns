namespace StatePattern;

/// <summary>
/// 未投币状态：投币后切换到已投币状态，其余动作被拒绝。
/// </summary>
public class NoQuarterState(GumballMachine machine) : IState
{
    public void InsertQuarter()
    {
        Console.WriteLine("[投币成功] 已投入硬币");
        machine.State = machine.HasQuarter;
    }

    public void EjectQuarter() => Console.WriteLine("[拒绝] 还未投币，无可退币");

    public void TurnCrank() => Console.WriteLine("[拒绝] 请先投币再转动摇杆");

    public void Dispense() => Console.WriteLine("[拒绝] 无法出货");
}
