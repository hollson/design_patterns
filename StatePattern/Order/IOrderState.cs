namespace StatePattern;

/// <summary>
/// 状态接口，定义订单在任何状态下可响应的全部操作。
/// </summary>
public interface IOrderState
{
    void Pay(Order order);

    void Ship(Order order);

    void Complete(Order order);

    void Cancel(Order order);
}
