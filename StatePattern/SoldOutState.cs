namespace StatePattern;

/// <summary>
/// 售罄状态——所有操作均不可用
/// </summary>
public class SoldOutState : IState
{
    public GumballMachine Machine { get; }

    public SoldOutState(GumballMachine gumballMachine) => Machine = gumballMachine;

    public void InsertQuarter() => Console.WriteLine("抱歉！已售罄");

    public void EjectQuarter() => Console.WriteLine("售罄时无法退币");

    public void TurnCrank() => Console.WriteLine("转动摇杆无效");

    public void Dispense() => Console.WriteLine("缺货时无法出货");
}
