namespace StatePattern;

/// <summary>
/// 出货状态：放出糖果后，视库存切回未投币或售罄状态。
/// </summary>
public class SoldState(GumballMachine machine) : IState
{
    public void InsertQuarter() => Console.WriteLine("[拒绝] 请等待，正在出货");

    public void EjectQuarter() => Console.WriteLine("[拒绝] 已转动摇杆，无法退币");

    public void TurnCrank() => Console.WriteLine("[拒绝] 重复转动无效");

    public void Dispense()
    {
        machine.ReleaseBall();
        machine.State = machine.Count > 0 ? machine.NoQuarter : machine.SoldOut;
    }
}
