namespace CompositePattern;

/// <summary>
/// 抽象组件（安全式）：只声明叶子与容器共有的操作，
/// Add 仅出现在 Department 上，编译期即可拦截误用。
/// </summary>
public interface IOrgUnit
{
    int HeadCount();

    decimal TotalSalary();

    void Print(int indent = 0);
}
