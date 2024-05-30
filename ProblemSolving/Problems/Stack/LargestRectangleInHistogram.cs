namespace ProblemSolving.Problems.Stack;

// https://leetcode.com/problems/largest-rectangle-in-histogram/description/

public static class LargestRectangleInHistogram
{
    public static int Solution(int[] heights)
    {
        var largest = 0;
        var length = heights.Length;
        Stack<(int, int)> stack = new();
        for (var i = 0; i < heights.Length; i++)
        {
            var h = heights[i];
            if (stack.Count == 0)
            {
                stack.Push((h, i));
                largest = h;
                continue;
            }

            var c = i;
            stack.TryPeek(out var top);
            while (h <= top.Item1)
            {
                var popped = stack.Pop();
                largest = largest > popped.Item1 * (i-popped.Item2) ? largest : popped.Item1 * (i-popped.Item2);
                c = popped.Item2;

                if (!stack.TryPeek(out top)) break;
            }

            stack.Push((h, c));
        }

        while (stack.Count != 0)
        {
            var popped = stack.Pop();
            largest = largest > popped.Item1 * (length-popped.Item2) ? largest : popped.Item1 * (length-popped.Item2);
            
        }

        return largest;
    }
}