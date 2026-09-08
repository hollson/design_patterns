namespace StrategyPattern;

/// <summary>
/// 快速排序
/// </summary>
class QuickSort : ISortStrategy
{
    public void Sort(int[] array)
    {
        QuickSortHelper(array, 0, array.Length - 1);
        Console.WriteLine("快速排序完成");
    }

    void QuickSortHelper(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(arr, low, high);
            QuickSortHelper(arr, low, pivot - 1);
            QuickSortHelper(arr, pivot + 1, high);
        }
    }

    int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
            if (arr[j] < pivot)
                (arr[++i], arr[j]) = (arr[j], arr[i]);
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }
}