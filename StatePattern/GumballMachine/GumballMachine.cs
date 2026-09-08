namespace StatePattern;

/// <summary>
/// 上下文，持有当前状态并把所有动作委托给它，自身不含任何状态判断分支。
/// </summary>
public class GumballMachine
{
    public int Count { get; private set; }

    public IState State { get; set; }

    public IState NoQuarter { get; }

    public IState HasQuarter { get; }

    public IState Sold { get; }

    public IState SoldOut { get; }

    public GumballMachine(int count)
    {
        Count = count;
        NoQuarter = new NoQuarterState(this);
        HasQuarter = new HasQuarterState(this);
        Sold = new SoldState(this);
        SoldOut = new SoldOutState();
        State = count > 0 ? NoQuarter : SoldOut;
        Console.WriteLine($"[糖果机] 装填 {count} 颗糖果");
    }

    public void InsertQuarter() => State.InsertQuarter();

    public void EjectQuarter() => State.EjectQuarter();

    public void TurnCrank()
    {
        State.TurnCrank();
        State.Dispense(); // 转把后自动触发出货，状态可能已被切换
    }

    public void ReleaseBall()
    {
        Count--;
        Console.WriteLine($"[出货] 一颗糖果滚落出来（剩余 {Count} 颗）");
        if (Count == 0)
            Console.WriteLine("[售罄] 糖果已售完");
    }
}
