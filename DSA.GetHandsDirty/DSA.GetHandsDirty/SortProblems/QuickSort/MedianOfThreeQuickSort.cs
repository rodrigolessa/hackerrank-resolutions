namespace DSA.GetHandsDirty.SortProblems.QuickSort;

public class MedianOfThreeQuickSort
{
    private static int MedianOfThreePivot(int[] s, int l, int r)
    {
        int mid = l + (r - l) / 2;

        int a = s[l];
        int b = s[mid];
        int c = s[r];

        int pivot =
            (a > b) ? ((a < c) ? a : (b > c ? b : c))
                : ((b < c) ? b : (a > c ? a : c));
        
        return pivot;
    }
}