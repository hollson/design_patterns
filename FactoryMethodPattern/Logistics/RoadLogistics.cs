namespace FactoryMethodPattern;

/// <summary>公路物流（具体创建者）：只回答"调度什么"</summary>
public class RoadLogistics : Logistics
{
    protected override string Name => "公路物流";

    protected override ITransport CreateTransport() => new Truck();     // 决定造卡车
}
