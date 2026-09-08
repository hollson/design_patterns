namespace CommandPattern;

/// <summary>
/// 调用者，用撤销/重做两个栈管理命令历史，等价于编辑器的 Ctrl+Z 与 Ctrl+Y。
/// </summary>
public class UndoManager
{
    private readonly Stack<IEditCommand> _undoStack = new();
    private readonly Stack<IEditCommand> _redoStack = new();

    public void Execute(IEditCommand command)
    {
        command.Execute();
        _undoStack.Push(command);
        _redoStack.Clear(); // 新操作会使重做历史失效
    }

    public void Undo()
    {
        if (_undoStack.Count == 0)
        {
            Console.WriteLine("  没有可撤销的操作");
            return;
        }
        var command = _undoStack.Pop();
        command.Undo();
        _redoStack.Push(command);
    }

    public void Redo()
    {
        if (_redoStack.Count == 0)
        {
            Console.WriteLine("  没有可重做的操作");
            return;
        }
        var command = _redoStack.Pop();
        command.Execute();
        _undoStack.Push(command);
    }
}
