namespace TemplatePattern;

/// <summary>库存测试（具体类）：演示失败路径——断言抛异常，TearDown 依然执行</summary>
public class InventoryTest() : TestBase("库存扣减测试")
{
    private int _stock;

    protected override void Setup()
    {
        _stock = 5;                                              // 造数：预置 5 件库存
        Console.WriteLine("[Setup] 预置商品库存 5 件");
    }

    protected override void Test()
    {
        Console.WriteLine("[Test] 下单购买 8 件");
        if (_stock < 8)
            throw new Exception($"库存不足：剩 {_stock} 件，需要 8 件");
    }

    protected override void TearDown() => Console.WriteLine("[Teardown] 回滚测试数据，恢复库存");
}
