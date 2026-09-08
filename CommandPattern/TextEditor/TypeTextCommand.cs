namespace CommandPattern;

/// <summary>
/// 具体命令，封装输入文本动作，撤销 = 退格删除刚输入的内容。
/// </summary>
public class TypeTextCommand(Editor editor, string text) : IEditCommand
{
    public void Execute() => editor.Type(text);

    public void Undo() => editor.Backspace(text.Length);
}
