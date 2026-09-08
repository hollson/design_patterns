namespace FactoryMethodPattern;

/// <summary>货机（具体产品）：空运，最快但最贵</summary>
public class Plane : ITransport
{
    public string Name => "货机";

    public void Deliver() => Console.WriteLine("[运输] 货机航空直达，约 1 天，运费最高");
}
