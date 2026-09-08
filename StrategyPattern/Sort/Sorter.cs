namespace StrategyPattern;

/// <summary>
/// 排序上下文：持有排序策略，委托执行
/// </summary>
class Sorter
{
    private ISortStrategy _strategy;

    public Sorter(ISortStrategy strategy) => _strategy = strategy;

    public void SetStrategy(ISortStrategy strategy) => _strategy = strategy;

    public void Sort(int[] array) => _strategy.Sort(array);
}