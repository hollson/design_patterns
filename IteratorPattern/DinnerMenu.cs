using System.Collections;

namespace IteratorPattern;

/// <summary>
/// 晚餐菜单，内部使用固定大小数组存储菜单项。
/// </summary>
public class DinnerMenu
{
    private const int Max = 1;
    private int _count;
    private Menu[] _items;

    public IEnumerable Items => new DinnerMenuIterator(_items);

    public DinnerMenu()
    {
        _items = new Menu[Max];
        AddItems("Hamburger", "Hamburger with cheese and onions", 160, false);
    }

    private void AddItems(string name, string description, int price, bool veg)
    {
        var item = new Menu(name, description, price, veg);
        if (_count <= Max)
        {
            _items[_count] = item;
            _count++;
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
    }
}
