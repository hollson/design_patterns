namespace MediatorPattern;

/// <summary>塔台（中介者接口）：所有协调规则的契约</summary>
public interface ITowerMediator
{
    void Register(Aircraft aircraft);          // 飞机进入空域

    void CoordinateLanding(Aircraft requester);     // 协调降落

    void CoordinateTakeoff(Aircraft requester);     // 协调起飞
}
