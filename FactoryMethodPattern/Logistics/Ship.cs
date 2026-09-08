namespace FactoryMethodPattern;

/// <summary>货轮（具体产品）：海运，适合大宗货物</summary>
public class Ship : ITransport
{
    public string Name => "货轮";

    public void Deliver() => Console.WriteLine("[运输] 货轮跨洋海运，约 15 天，适合大宗货物");
}
