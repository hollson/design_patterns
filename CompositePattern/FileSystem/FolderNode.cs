namespace CompositePattern;

/// <summary>
/// 组合节点：文件夹，持有子节点列表，全部操作递归下发给子节点。
/// </summary>
public class FolderNode(string name) : FileSystemNode(name)
{
    private readonly List<FileSystemNode> _children = [];

    public override void Add(FileSystemNode node) => _children.Add(node);

    public override void Remove(FileSystemNode node) => _children.Remove(node);

    // 总大小 = 所有子节点大小之和，子文件夹继续向下一层求和
    public override long Size() => _children.Sum(child => child.Size());

    public override void Display(int indent = 0)
    {
        Console.WriteLine($"{new string(' ', indent)}{Name}/  (共 {Size()} B)");
        foreach (var child in _children)
            child.Display(indent + 2);   // 递归展开，缩进加深
    }
}
