namespace DSA.GetHandsDirty.GraphProblems;

public class CourseSchedule
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        if (numCourses <= 1)
            return true;

        Dictionary<int, HashSet<int>> courseMap = new Dictionary<int, HashSet<int>>();
        for (int i = 0; i < numCourses; i++)
        {
            courseMap.Add(i, new HashSet<int>());
        }

        foreach (int[] course in prerequisites)
        {
            int courseId = course[0];
            int prerequisiteCourseId = course[1];
            courseMap[prerequisiteCourseId].Add(courseId);
        }

        // 0 = Unknow
        // 1 = Visiting
        // 2 = Visited
        int[] visitStatus = new int[numCourses];

        for (int i = 0; i < numCourses; i++)
            if (HasCycle(i))
                return false;

        return true;

        bool HasCycle(int courseId)
        {
            if (visitStatus[courseId] == 1)
                return true;

            if (visitStatus[courseId] == 2)
                return false;

            visitStatus[courseId] = 1;

            foreach (int prerequisiteId in courseMap[courseId])
                if (HasCycle(prerequisiteId))
                    return true;

            visitStatus[courseId] = 2;

            return false;
        }
    }
}