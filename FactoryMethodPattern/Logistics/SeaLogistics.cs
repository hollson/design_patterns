namespace FactoryMethodPattern;

/// <summary>海运物流（具体创建者）</summary>
public class SeaLogistics : Logistics
{
    protected override string Name => "海运物流";

    protected override ITransport CreateTransport() => new Ship();      // 决定造货轮
}
