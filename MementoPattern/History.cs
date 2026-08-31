// 管理者：负责保存和提供备忘录
public class History
{
    private readonly List<EditorMemento> _mementos = new();

    public void Push(EditorMemento memento) => _mementos.Add(memento);

    public EditorMemento Pop()
    {
        if (_mementos.Count > 0)
        {
            var memento = _mementos[^1];
            _mementos.RemoveAt(_mementos.Count - 1);
            return memento;
        }
        return null!;
    }
}
