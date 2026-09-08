namespace StatePattern;

/// <summary>
/// 售罄状态：终结状态，所有动作均被拒绝。
/// </summary>
public class SoldOutState : IState
{
    public void InsertQuarter() => Console.WriteLine("[拒绝] 糖果已售罄");

    public void EjectQuarter() => Console.WriteLine("[拒绝] 售罄状态无法退币");

    public void TurnCrank() => Console.WriteLine("[拒绝] 转动摇杆无效");

    public void Dispense() => Console.WriteLine("[拒绝] 缺货无法出货");
}
