namespace CommandPattern;

/// <summary>
/// 宏命令，将多个命令组合为一个复合命令，批量执行、反序撤销。
/// </summary>
public class MacroCommand(ICommand[] commands) : ICommand
{
    private readonly ICommand[] _commands = commands;

    public void Execute()
    {
        foreach (var cmd in _commands)
            cmd.Execute();
    }

    public void Undo()
    {
        // 反序撤销，保证状态正确回退
        for (var i = _commands.Length - 1; i >= 0; i--)
            _commands[i].Undo();
    }
}
