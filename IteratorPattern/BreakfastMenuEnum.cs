using System.Collections;

namespace IteratorPattern;

/// <summary>
/// 早餐菜单枚举器，逐项遍历 List 中的菜单项。
/// </summary>
public class BreakfastMenuEnum : IEnumerator
{
    private readonly List<Menu> _items;
    private int _position = -1;

    public BreakfastMenuEnum(List<Menu> items)
    {
        _items = items;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        _position++;
        return _position < _items.Count;
    }

    public void Reset()
    {
        _position = -1;
    }

    object IEnumerator.Current => Current;

    public Menu Current
    {
        get
        {
            try
            {
                return _items[_position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
