// 发起人：文本编辑器
public class Editor
{
    private string _content = "";

    public void Type(string words)
    {
        _content += words;
        Console.WriteLine($"输入: {words}");
    }

    public string GetContent() => _content;

    // 创建备忘录：保存当前状态
    public EditorMemento CreateMemento()
    {
        return new EditorMemento(_content);
    }

    // 从备忘录恢复状态
    public void Restore(EditorMemento memento)
    {
        _content = memento.Content;
    }
}
