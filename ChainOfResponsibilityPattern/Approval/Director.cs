namespace ChainOfResponsibilityPattern;

/// <summary>总监（具体处理者）：5 万元以内</summary>
public class Director(string name) : Approver(name)
{
    protected override bool CanApprove(decimal amount) => amount <= 50_000;
}
