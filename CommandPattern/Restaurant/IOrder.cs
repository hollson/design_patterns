namespace CommandPattern;

/// <summary>
/// 命令接口，将"烹饪请求"封装为订单对象，服务员只依赖它，不感知厨师细节。
/// </summary>
public interface IOrder
{
    void Cook();
}
