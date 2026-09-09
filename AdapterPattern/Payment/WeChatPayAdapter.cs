namespace AdapterPattern;

/// <summary>微信支付适配器：元 → 分，接口名对齐统一网关</summary>
public class WeChatPayAdapter(WeChatPaySdk sdk) : IPaymentGateway
{
    public void Pay(string orderNo, decimal yuan)
    {
        Console.WriteLine($"[适配] 微信适配器：¥{yuan} → {yuan * 100:0} 分");
        sdk.UnifiedOrder(orderNo, (int)(yuan * 100));     // 元转分后转调
    }

    public void Refund(string orderNo, decimal yuan)
    {
        Console.WriteLine($"[适配] 微信适配器：¥{yuan} → {yuan * 100:0} 分");
        sdk.RefundOrder(orderNo, (int)(yuan * 100));
    }
}
