namespace ProblemSolving.Problems.Intervals;

// https://leetcode.com/problems/summary-ranges/description/?envType=study-plan-v2&envId=top-interview-150

public class SummaryRanges
{
    public static IList<string> Solution(int[] nums)
    {
        var solution = new List<string>();

        if (nums.Length == 0)
            return solution;

        int j = 0;
        solution.Add($"{nums[0]}");

        for (int i = 0; i < nums.Length - 1; i++)
        {

            if (nums[i] + 1 == nums[i + 1])
                continue;

            if (int.Parse(solution[j]) != nums[i])
                solution[j] += $"->{nums[i]}";
            j++;
            solution.Add($"{nums[i + 1]}");


        }

        if (int.Parse(solution[j]) != nums.Last())
            solution[j] += $"->{nums.Last()}";

        return solution;
    }
}
