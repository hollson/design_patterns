namespace CommandPattern;

/// <summary>
/// 空命令对象，用于初始化遥控器的默认槽位，避免空引用检查
/// </summary>
internal class NoCommand : ICommand
{
    public void Execute() => Console.WriteLine("未分配命令");

    public void Undo() => Execute();
}
