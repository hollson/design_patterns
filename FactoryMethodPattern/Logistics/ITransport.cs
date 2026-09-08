namespace FactoryMethodPattern;

/// <summary>运输工具（产品）：所有运输方式实现统一契约</summary>
public interface ITransport
{
    string Name { get; }     // 运输方式名称

    void Deliver();          // 执行运输
}
