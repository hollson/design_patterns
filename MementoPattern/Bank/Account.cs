namespace MementoPattern;

/// <summary>银行账户（发起人）：余额是内部状态，快照只能经自己的方法创建/恢复</summary>
public class Account(string owner, decimal balance, decimal depositLimit = decimal.MaxValue)
{
    public string Owner { get; } = owner;

    private decimal _balance = balance;

    private decimal DepositLimit { get; } = depositLimit;        // 单笔入账风控限额

    public void Show() => Console.WriteLine($"[账户] {Owner} 余额 ¥{_balance:0.00}");

    /// <summary>扣款（转账转出方）</summary>
    public void Withdraw(decimal amount)
    {
        if (amount > _balance)
            throw new InvalidOperationException($"{Owner} 余额不足：¥{_balance:0.00} < ¥{amount:0.00}");
        _balance -= amount;
        Console.WriteLine($"[转出] {Owner} 扣款 ¥{amount:0.00}，余额 ¥{_balance:0.00}");
    }

    /// <summary>入账（转账转入方）：超风控限额则失败</summary>
    public void Deposit(decimal amount)
    {
        if (amount > DepositLimit)
            throw new InvalidOperationException($"{Owner} 单笔入账限额 ¥{DepositLimit:0.00}，¥{amount:0.00} 超限");
        _balance += amount;
        Console.WriteLine($"[转入] {Owner} 入账 ¥{amount:0.00}，余额 ¥{_balance:0.00}");
    }

    /// <summary>转账前存快照</summary>
    public BalanceSnapshot CreateSnapshot() => new(_balance);

    /// <summary>失败后回滚</summary>
    public void Restore(BalanceSnapshot snapshot) => _balance = snapshot.Balance;
}
