namespace CompositePattern;

/// <summary>
/// 叶子节点：员工，人数为 1，薪资为本人月薪。
/// </summary>
public class Employee(string name, decimal salary) : IOrgUnit
{
    public int HeadCount() => 1;

    public decimal TotalSalary() => salary;

    public void Print(int indent = 0)
        => Console.WriteLine($"{new string(' ', indent)}员工 {name}  月薪 {salary}");
}
