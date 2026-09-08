namespace FactoryMethodPattern;

/// <summary>航空物流（具体创建者）：新增空运只需新增本类 + Plane，其余代码零改动</summary>
public class AirLogistics : Logistics
{
    protected override string Name => "航空物流";

    protected override ITransport CreateTransport() => new Plane();     // 决定造货机
}
