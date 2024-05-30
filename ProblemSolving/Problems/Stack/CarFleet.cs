namespace ProblemSolving.Problems.Stack;

// https://leetcode.com/problems/car-fleet/

public static class CarFleet
{
    public static int Solution(int target, int[] position, int[] speed)
    {
        var arr = position.Zip(speed);
        arr = arr.OrderByDescending(x => x.First);
        Stack<double> stack = new();
        
        foreach (var element in arr)
        {
            var time = (target - element.First) / (double)element.Second;
            if(!stack.TryPeek(out var lastTime) || time > lastTime)
                stack.Push(time);
        }

        return stack.Count;
    }
}