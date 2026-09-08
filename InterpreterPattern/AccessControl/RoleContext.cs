namespace InterpreterPattern;

/// <summary>求值上下文：携带当前用户与角色集合（终结符从这里取值）</summary>
public class RoleContext(string user, string[] roles)
{
    public string User { get; } = user;

    public string RolesText => string.Join("、", roles);        // 演示输出用

    private HashSet<string> RoleSet { get; } = [.. roles];      // 集合表达式初始化

    public bool HasRole(string role) => RoleSet.Contains(role);
}
