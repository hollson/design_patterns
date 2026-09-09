namespace ChainOfResponsibilityPattern;

/// <summary>部门经理（具体处理者）：5000 元以内</summary>
public class Manager(string name) : Approver(name)
{
    protected override bool CanApprove(decimal amount) => amount <= 5000;
}
