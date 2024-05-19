namespace ProblemSolving.Problems.Hashmap;

// https://leetcode.com/problems/contains-duplicate/description/

public static class ContainsDuplicate
{
    public static bool Solution(int[] nums)
    {
        HashSet<int> set = [];
        foreach (var n in nums)
        {
            if (!set.Add(n))
                return true;
        }
        return false;
    }
}