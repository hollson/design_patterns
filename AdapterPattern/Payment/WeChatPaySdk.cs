namespace AdapterPattern;

/// <summary>微信支付 SDK（被适配者）：第三方接口，金额单位是"分"，无法修改</summary>
public class WeChatPaySdk
{
    /// <summary>统一下单——只认 int 分</summary>
    public void UnifiedOrder(string bizNo, int cents) =>
        Console.WriteLine($"[微信] UnifiedOrder 下单成功：{bizNo}，金额 {cents} 分");

    /// <summary>申请退款——只认 int 分</summary>
    public void RefundOrder(string bizNo, int cents) =>
        Console.WriteLine($"[微信] RefundOrder 退款成功：{bizNo}，金额 {cents} 分");
}
