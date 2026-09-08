namespace CompositePattern;

/// <summary>
/// 抽象组件（透明式）：统一声明叶子与容器的全部操作，
/// 叶子不支持的方法由基类抛出异常，客户端无需区分节点类型。
/// </summary>
public abstract class FileSystemNode(string name)
{
    public string Name { get; } = name;

    /// <summary>容器操作：仅文件夹支持，文件调用将抛异常（透明式的代价）。</summary>
    public virtual void Add(FileSystemNode node)
        => throw new NotSupportedException($"文件 {Name} 不能包含子节点");

    public virtual void Remove(FileSystemNode node)
        => throw new NotSupportedException($"文件 {Name} 不能包含子节点");

    public abstract long Size();

    public abstract void Display(int indent = 0);
}
