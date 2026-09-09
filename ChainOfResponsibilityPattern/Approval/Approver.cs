namespace ChainOfResponsibilityPattern;

/// <summary>审批人（抽象处理者）：能审就审，审不了就上报</summary>
public abstract class Approver(string name)
{
    private Approver? _next;                    // 下一位审批人（后继者）

    protected string Name { get; } = name;

    /// <summary>设置下一位审批人——返回 next 便于链式组装</summary>
    public Approver SetNext(Approver next)
    {
        _next = next;
        return next;
    }

    /// <summary>处理报销：金额在权限内就批，否则传给下一位</summary>
    public void Process(ExpenseRequest request)
    {
        if (CanApprove(request.Amount))
        {
            Console.WriteLine($"[通过] {Name} 审批通过：{request.Applicant} 的「{request.Purpose}」¥{request.Amount}");
        }
        else if (_next is not null)
        {
            Console.WriteLine($"[上报] {Name}：¥{request.Amount} 超出我的权限，转交 {_next.Name}");
            _next.Process(request);             // 传给后继者
        }
        else
        {
            Console.WriteLine($"[拒绝] {Name}：¥{request.Amount} 超出所有人权限，驳回");
        }
    }

    /// <summary>本审批人的金额权限</summary>
    protected abstract bool CanApprove(decimal amount);
}
