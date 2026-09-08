namespace CommandPattern;

/// <summary>
/// 调用者，持有命令槽位与历史栈，只触发命令，不认识任何接收者。
/// </summary>
public class RemoteControl
{
    private readonly ICommand[] _onCommands;
    private readonly ICommand[] _offCommands;
    private readonly Stack<ICommand> _history = new();

    public RemoteControl(int slots)
    {
        _onCommands = new ICommand[slots];
        _offCommands = new ICommand[slots];

        var none = new NoCommand();
        for (var i = 0; i < slots; i++)
        {
            _onCommands[i] = none;
            _offCommands[i] = none;
        }
    }

    // 将一对开/关命令绑定到槽位
    public void SetCommand(int slot, ICommand onCmd, ICommand offCmd)
    {
        _onCommands[slot] = onCmd;
        _offCommands[slot] = offCmd;
    }

    public void PushOn(int slot)
    {
        _onCommands[slot].Execute();
        _history.Push(_onCommands[slot]);
    }

    public void PushOff(int slot)
    {
        _offCommands[slot].Execute();
        _history.Push(_offCommands[slot]);
    }

    // 多步撤销：弹出最近执行的命令并回退
    public void PushUndo()
    {
        if (_history.Count == 0)
        {
            Console.WriteLine("没有可撤销的操作");
            return;
        }
        _history.Pop().Undo();
    }
}
