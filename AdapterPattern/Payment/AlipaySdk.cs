namespace AdapterPattern;

/// <summary>支付宝 SDK（被适配者）：第三方接口，金额是"元"字符串，无法修改</summary>
public class AlipaySdk
{
    /// <summary>创建交易——只认 string 元</summary>
    public void CreateTrade(string bizNo, string yuan) =>
        Console.WriteLine($"[支付宝] CreateTrade 创建交易：{bizNo}，金额 ¥{yuan}");

    /// <summary>退款——只认 string 元</summary>
    public void RefundTrade(string bizNo, string yuan) =>
        Console.WriteLine($"[支付宝] RefundTrade 退款成功：{bizNo}，金额 ¥{yuan}");
}
