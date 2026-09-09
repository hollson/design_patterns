namespace MementoPattern;

/// <summary>转账事务（管理者）：转出前存快照，任一步失败整体回滚</summary>
public static class TransferService
{
    /// <summary>转账：要么两步都成功，要么全额回滚（事务语义）</summary>
    public static void Transfer(Account from, Account to, decimal amount)
    {
        Console.WriteLine($">> 发起转账：{from.Owner} → {to.Owner} ¥{amount:0.00}");
        BalanceSnapshot backup = from.CreateSnapshot();       // 关键点：转出前拍快照
        try
        {
            from.Withdraw(amount);                            // 第一步：扣款
            to.Deposit(amount);                               // 第二步：入账
            Console.WriteLine("[事务] 转账成功，无需回滚");
        }
        catch (Exception e)
        {
            Console.WriteLine($"[事务] 失败：{e.Message}");
            from.Restore(backup);                             // 回滚：恢复快照
            Console.WriteLine($"[回滚] {from.Owner} 余额已恢复");
        }
    }
}
