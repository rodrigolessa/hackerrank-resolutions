namespace DSA.GetHandsDirty.SortProblems.QuickSort;

public static class QuickSortCommon
{
    public static void Swap(int[] arr, int leftPosition, int rightPosition)
    {
        (arr[leftPosition], arr[rightPosition]) = (arr[rightPosition], arr[leftPosition]);
    }
}