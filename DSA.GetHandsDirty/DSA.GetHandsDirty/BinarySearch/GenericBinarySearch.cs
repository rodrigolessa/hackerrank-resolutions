namespace DSA.GetHandsDirty.BinarySearch;

public static class GenericBinarySearch
{
    public static int Find(int[] numbers, int numberToFind, int left, int right, out int steps)
    {
        steps = 0;
        while (left <= right)
        {
            var middle = (left + right) / 2;
            if (numbers[middle] == numberToFind)
            {
                return middle;
            } 
            
            if (numbers[middle] > numberToFind)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }

            steps++;
        }
        
        return -1;
    }
}