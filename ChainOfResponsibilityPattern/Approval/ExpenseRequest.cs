namespace ChainOfResponsibilityPattern;

/// <summary>报销申请（请求对象）：金额与事由</summary>
public record ExpenseRequest(string Applicant, string Purpose, decimal Amount);
