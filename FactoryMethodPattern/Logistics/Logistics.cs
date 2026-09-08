namespace FactoryMethodPattern;

/// <summary>物流公司（抽象创建者）：固化「受理 → 调度 → 运输」流程</summary>
public abstract class Logistics
{
    /// <summary>安排一次运输：流程固定，运输工具由子类决定</summary>
    public void PlanDelivery(string cargo)
    {
        Console.WriteLine($"[受理] {Name}：货物「{cargo}」");
        ITransport transport = CreateTransport();       // 工厂方法：延迟到子类决定
        Console.WriteLine($"[调度] {transport.Name}已就位");
        transport.Deliver();
    }

    protected abstract string Name { get; }             // 物流公司名

    /// <summary>工厂方法：由子类决定调度哪种运输工具</summary>
    protected abstract ITransport CreateTransport();
}
