namespace StrategyPattern;

/// <summary>
/// 归并排序
/// </summary>
class MergeSort : ISortStrategy
{
    public void Sort(int[] array)
    {
        MergeSortHelper(array, 0, array.Length - 1);
        Console.WriteLine("归并排序完成");
    }

    void MergeSortHelper(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortHelper(arr, left, mid);
            MergeSortHelper(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;
        while (i <= mid && j <= right)
            temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];
        while (i <= mid) temp[k++] = arr[i++];
        while (j <= right) temp[k++] = arr[j++];
        Array.Copy(temp, 0, arr, left, temp.Length);
    }
}