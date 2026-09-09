namespace AdapterPattern;

/// <summary>支付宝适配器：元 → "x.xx" 字符串，接口名对齐统一网关</summary>
public class AlipayAdapter(AlipaySdk sdk) : IPaymentGateway
{
    public void Pay(string orderNo, decimal yuan)
    {
        Console.WriteLine($"[适配] 支付宝适配器：¥{yuan} → \"{yuan:0.00}\" 字符串");
        sdk.CreateTrade(orderNo, $"{yuan:0.00}");          // 元格式化后转调
    }

    public void Refund(string orderNo, decimal yuan)
    {
        Console.WriteLine($"[适配] 支付宝适配器：¥{yuan} → \"{yuan:0.00}\" 字符串");
        sdk.RefundTrade(orderNo, $"{yuan:0.00}");
    }
}
