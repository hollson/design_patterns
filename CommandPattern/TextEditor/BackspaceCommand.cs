namespace CommandPattern;

/// <summary>
/// 具体命令，封装退格动作，执行时记录被删内容，撤销 = 重新输回。
/// </summary>
public class BackspaceCommand(Editor editor, int length) : IEditCommand
{
    private string _removed = "";

    public void Execute() => _removed = editor.Backspace(length);

    public void Undo() => editor.Type(_removed);
}
