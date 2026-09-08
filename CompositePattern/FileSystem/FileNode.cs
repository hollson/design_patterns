namespace CompositePattern;

/// <summary>
/// 叶子节点：文件，大小即自身字节数。
/// </summary>
public class FileNode(string name, long size) : FileSystemNode(name)
{
    public override long Size() => size;

    public override void Display(int indent = 0)
        => Console.WriteLine($"{new string(' ', indent)}{Name}  ({Size()} B)");
}
