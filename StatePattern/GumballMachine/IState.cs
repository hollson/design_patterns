namespace StatePattern;

/// <summary>
/// 状态接口，定义糖果机在任何状态下可响应的全部动作。
/// </summary>
public interface IState
{
    void InsertQuarter();

    void EjectQuarter();

    void TurnCrank();

    void Dispense();
}
