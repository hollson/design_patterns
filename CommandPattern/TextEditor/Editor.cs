using System.Text;

namespace CommandPattern;

/// <summary>
/// 接收者，维护文本内容，执行实际的输入与退格操作。
/// </summary>
public class Editor
{
    private readonly StringBuilder _text = new();

    public void Type(string text)
    {
        _text.Append(text);
        Show();
    }

    // 从末尾删除指定长度字符，返回被删内容供撤销时恢复
    public string Backspace(int length)
    {
        var removed = _text.ToString(_text.Length - length, length);
        _text.Remove(_text.Length - length, length);
        Show();
        return removed;
    }

    public void Show() => Console.WriteLine($"  [编辑器] \"{_text}\"");
}
