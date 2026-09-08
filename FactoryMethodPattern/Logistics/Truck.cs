namespace FactoryMethodPattern;

/// <summary>卡车（具体产品）：公路运输，便宜但慢</summary>
public class Truck : ITransport
{
    public string Name => "卡车";

    public void Deliver() => Console.WriteLine("[运输] 卡车沿公路配送，约 3 天，运费最低");
}
