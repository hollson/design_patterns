using System.Collections;

namespace IteratorPattern;

/// <summary>
/// 早餐菜单迭代器，封装 List 的遍历逻辑。
/// </summary>
class BreakfastMenuIterator(List<Menu> items) : IEnumerable
{
    private readonly List<Menu> _items = items;

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator GetEnumerator() => new BreakfastMenuEnum(_items);
}
