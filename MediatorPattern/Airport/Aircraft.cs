namespace MediatorPattern;

/// <summary>飞行器（抽象同事）：只认识塔台，不认识其他飞行器</summary>
public abstract class Aircraft(string callSign)
{
    protected ITowerMediator Tower { get; set; } = null!;   // 中介者引用

    public string CallSign { get; } = callSign;             // 呼号

    /// <summary>由塔台登记时注入中介者</summary>
    public void RegisterTower(ITowerMediator tower) => Tower = tower;

    /// <summary>请求降落</summary>
    public void RequestLanding()
    {
        Console.WriteLine($">> {CallSign}：请求降落");
        Tower.CoordinateLanding(this);
    }

    /// <summary>请求起飞</summary>
    public void RequestTakeoff()
    {
        Console.WriteLine($">> {CallSign}：请求起飞");
        Tower.CoordinateTakeoff(this);
    }

    /// <summary>接收塔台指令</summary>
    public abstract void Receive(string instruction);
}
