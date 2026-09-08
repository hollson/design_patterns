namespace CommandPattern;

/// <summary>
/// 空命令对象，初始化遥控器默认槽位，避免空引用检查（空对象模式）。
/// </summary>
public class NoCommand : ICommand
{
    public void Execute() => Console.WriteLine("该槽位未分配命令");

    public void Undo() => Execute();
}
