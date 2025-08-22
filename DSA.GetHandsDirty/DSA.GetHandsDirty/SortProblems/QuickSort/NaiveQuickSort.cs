namespace DSA.GetHandsDirty.SortProblems.QuickSort;

/// <summary>
/// Divide and conquer
/// </summary>
public static class NaiveQuickSort
{
    public static void NaiveSort(int[] arr, int left, int right)
    {
        if (left >= right) return;
        var pivotIndex = NaivePartition(arr, left, right);
        NaiveSort(arr, left, pivotIndex - 1);
        NaiveSort(arr, pivotIndex + 1, right);
    }

    private static int NaivePartition(int[] arr, int left, int right)
    {
        var pivotValue = NaiveWayToFindThePivot(arr, left, right);
        var position = left - 1;
        for (var j = left; j < right; j++)
        {
            if (arr[j] > pivotValue) continue;
            position++;
            QuickSortCommon.Swap(arr, position, j);
        }

        position++;
        
        // TODO: Improve this when find a better solution to select a Pivot
        QuickSortCommon.Swap(arr, position, right);

        return position;
    }

    /// <summary>
    /// First or Last Element (naïve)
    /// Very simple, but bad for sorted or nearly sorted input → leads to O(n²).
    /// Only used in teaching or when you know the data is random.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="l"></param>
    /// <param name="r"></param>
    /// <returns></returns>
    private static int NaiveWayToFindThePivot(int[] s, int l, int r)
    {
        return s[r];
    }
}