using System.Collections;

namespace IteratorPattern;

/// <summary>浏览器历史（聚合）：yield 迭代器方法，几行实现多种遍历</summary>
public class BrowserHistory : IEnumerable<string>
{
    private readonly List<string> _records = [];      // 集合表达式初始化

    public void Visit(params string[] urls) => _records.AddRange(urls);

    /// <summary>正序遍历（foreach 默认入口）：编译器自动生成状态机</summary>
    public IEnumerator<string> GetEnumerator()
    {
        foreach (var url in _records)
            yield return url;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>倒序遍历（最近优先）——同一集合的第二种遍历方式</summary>
    public IEnumerable<string> GetRecentFirst()
    {
        for (int i = _records.Count - 1; i >= 0; i--)
            yield return _records[i];
    }

    /// <summary>只取最近 N 条——LINQ 本身也构建在迭代器之上</summary>
    public IEnumerable<string> GetRecent(int count) => _records.TakeLast(count);
}
