namespace DSA.GetHandsDirty.ExponentialSearch;

public static class GenericExponentialSearch
{
    public static int Find(int[] input, int numberToFind, out int steps)
    {
        steps = 0;
        
        if (input[0] == numberToFind)
            return 0;
        
        var right = 1;
        var inputLength = input.Length - 1;
        while (right < inputLength && input[right] < numberToFind)
        {
            right *= 2;
            steps++;
        }

        if (input[right] == numberToFind)
            return right;

        var position = BinarySearch.GenericBinarySearch.Find(input, numberToFind, (right/2), Math.Min(right, inputLength), out var binarySteps);
        
        steps += binarySteps;

        return position;
    }
}