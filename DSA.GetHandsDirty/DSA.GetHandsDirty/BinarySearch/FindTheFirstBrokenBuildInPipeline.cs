namespace DSA.GetHandsDirty.BinarySearch;

public static class FindTheFirstBrokenBuildInPipeline
{
    /// <summary>
    /// Have to move the pointer to the further left, because after the first broken build the others will be broken too
    /// </summary>
    /// <param name="builds"></param>
    /// <param name="isBuildBroken"></param>
    /// <param name="steps"></param>
    /// <returns></returns>
    public static int Find(int[] builds, Func<int, bool> isBuildBroken, out int steps)
    {
        var left = 0;
        var right = builds.Length - 1;
        var result = -1;
        steps = 0;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (isBuildBroken(builds[mid]))
            {
                result = builds[mid];
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }

            steps++;
        }

        return result;
    }
}