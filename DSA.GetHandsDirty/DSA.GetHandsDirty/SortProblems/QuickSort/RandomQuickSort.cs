namespace DSA.GetHandsDirty.SortProblems.QuickSort;

public class RandomQuickSort
{
    private static (int, int) FindThePivotRandomly(int[] s, int l, int r)
    {
        Random rnd = new Random();
        int pivotIndex = rnd.Next(l, r + 1);
        return (pivotIndex, s[pivotIndex]);
    }
    
    public static void SortRandomly(int[] arr, int left, int right)
    {
        if (left >= right) return;
        var pivotIndex = PartitionUsingRandomPivot(arr, left, right);
        SortRandomly(arr, left, pivotIndex - 1);
        SortRandomly(arr, pivotIndex + 1, right);
    }

    private static int PartitionUsingRandomPivot(int[] arr, int left, int right)
    {
        var (pivotIndex, pivotValue) = FindThePivotRandomly(arr, left, right);
        var position = left;
        
        // Move pivot to the end (right) for simplicity
        QuickSortCommon.Swap(arr, pivotIndex, right);
        
        for (var j = left; j < right; j++)
        {
            if (arr[j] > pivotValue) continue;
            QuickSortCommon.Swap(arr, position, j);
            position++;
        }
        
        // TODO: Improve this when find a better solution to select a Pivot
        QuickSortCommon.Swap(arr, position, right);

        return position;
    }
}