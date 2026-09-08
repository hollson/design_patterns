namespace StrategyPattern;

/// <summary>
/// 排序策略接口
/// </summary>
interface ISortStrategy
{
    void Sort(int[] array);
}