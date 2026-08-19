namespace StatePattern;

/// <summary>
/// 状态接口，定义糖果机在各状态下可执行的操作
/// </summary>
public interface IState
{
    void InsertQuarter();
    void EjectQuarter();
    void TurnCrank();
    void Dispense();
}
