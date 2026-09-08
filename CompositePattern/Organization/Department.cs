namespace CompositePattern;

/// <summary>
/// 组合节点：部门，可混合包含子部门与员工，统计值递归聚合。
/// </summary>
public class Department(string name) : IOrgUnit
{
    private readonly List<IOrgUnit> _children = [];

    // 安全式：容器方法只在组合节点上声明
    public void Add(IOrgUnit unit) => _children.Add(unit);

    public int HeadCount() => _children.Sum(c => c.HeadCount());

    public decimal TotalSalary() => _children.Sum(c => c.TotalSalary());

    public void Print(int indent = 0)
    {
        Console.WriteLine($"{new string(' ', indent)}部门 {name}");
        foreach (var child in _children)
            child.Print(indent + 2);
    }
}
