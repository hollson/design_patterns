namespace ChainOfResponsibilityPattern;

/// <summary>组长（具体处理者）：500 元以内</summary>
public class TeamLead(string name) : Approver(name)
{
    protected override bool CanApprove(decimal amount) => amount <= 500;
}
