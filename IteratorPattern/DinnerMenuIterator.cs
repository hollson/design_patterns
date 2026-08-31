using System.Collections;

namespace IteratorPattern;

/// <summary>
/// 晚餐菜单迭代器，封装菜单数组的遍历逻辑。
/// </summary>
class DinnerMenuIterator(Menu[] items) : IEnumerable
{
    private readonly Menu[] _items = items;

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator GetEnumerator() => new DinnerMenuEnum(_items);
}
