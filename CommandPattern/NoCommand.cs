namespace CommandPattern;

/// <summary>
/// 空命令对象，用于初始化遥控器的默认槽位，避免空引用检查
/// </summary>
internal class NoCommand : ICommand
{
    public void Execute() => Console.WriteLine("No Command Assigned");

    public void Undo() => Execute();
}
