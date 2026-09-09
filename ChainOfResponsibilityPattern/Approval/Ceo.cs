namespace ChainOfResponsibilityPattern;

/// <summary>CEO（具体处理者）：不限额——链的末端</summary>
public class Ceo(string name) : Approver(name)
{
    protected override bool CanApprove(decimal amount) => true;
}
