namespace ProblemSolving.Problems.Stack;

// https://leetcode.com/problems/daily-temperatures/

public static class DailyTemperatures
{
    public static int[] Solution(int[] temperatures)
    {
        var result = new int[temperatures.Length];
        Stack<(int, int)> stack = new();
        var peek = (0,0);
        for (var i = 0; i < temperatures.Length; i++)
        {
            while (stack.TryPeek(out peek) && peek.Item1 < temperatures[i])
            {
                var tmp = stack.Pop();
                result[tmp.Item2] = i - tmp.Item2;
            }
            stack.Push((temperatures[i], i));
        }
        
        return result;
    }
}