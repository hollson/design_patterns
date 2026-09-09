namespace AdapterPattern;

/// <summary>统一支付网关（目标接口）：电商收银台期望的收付款接口</summary>
public interface IPaymentGateway
{
    void Pay(string orderNo, decimal yuan);      // 支付（单位：元）

    void Refund(string orderNo, decimal yuan);   // 退款（单位：元）
}
