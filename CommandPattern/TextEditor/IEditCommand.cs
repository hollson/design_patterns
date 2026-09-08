namespace CommandPattern;

/// <summary>
/// 命令接口，每次编辑操作封装为一个命令对象，支持正向执行与反向撤销。
/// </summary>
public interface IEditCommand
{
    void Execute();

    void Undo();
}
