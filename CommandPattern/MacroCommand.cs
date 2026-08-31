namespace CommandPattern;

/// <summary>
/// 宏命令，将多个命令组合成一个复合命令，可批量执行和撤销
/// </summary>
internal class MacroCommand(ICommand[] commands) : ICommand
{
    private readonly ICommand[] _commands = commands;

    public void Execute()
    {
        foreach (var item in _commands)
            item.Execute();
    }

    public void Undo()
    {
        foreach (var item in _commands)
            item.Undo();
    }
}
