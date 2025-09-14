using DSA.GetHandsDirty.GraphProblems;

namespace DSA.GetHandsDirty.UnitTests.GraphProblems;

public class CourseScheduleTests
{
    [Fact]
    public void CanFinish_GivenASequenceOfCoursesWithACircularDependency_ShouldReturnFalse()
    {
        int numCourses = 20;
        int[][] prerequisites = [[0, 10], [3, 18], [5, 5], [6, 11], [11, 14], [13, 1], [15, 1], [17, 4]];
        var solution = new CourseSchedule();
        var result =  solution.CanFinish(numCourses, prerequisites);
        result.ShouldBeFalse();
    }
    
    [Fact]
    public void CanFinish_GivenAOneCurseList_ShouldReturnTrue()
    {
        int numCourses = 1;
        int[][] prerequisites = [];
        var solution = new CourseSchedule();
        var result =  solution.CanFinish(numCourses, prerequisites);
        result.ShouldBeTrue();
    }
    
    [Fact]
    public void CanFinish_GivenATwoCoursesToTake_ShouldReturnTrue()
    {
        int numCourses = 2;
        int[][] prerequisites = [[1,0]];
        var solution = new CourseSchedule();
        var result =  solution.CanFinish(numCourses, prerequisites);
        result.ShouldBeTrue();
    }
    
    [Fact]
    public void CanFinish_GivenATwoCoursesWithDependency_ShouldReturnFalse()
    {
        int numCourses = 2;
        int[][] prerequisites = [[1,0],[0,1]];
        var solution = new CourseSchedule();
        var result =  solution.CanFinish(numCourses, prerequisites);
        result.ShouldBeFalse();
    }
}