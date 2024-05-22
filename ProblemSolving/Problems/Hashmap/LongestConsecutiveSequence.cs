namespace ProblemSolving.Problems.Hashmap;

// https://leetcode.com/problems/longest-consecutive-sequence/

public static class LongestConsecutiveSequence
{
    public static int Solution(int[] nums)
    {
        var set = new HashSet<int>(nums);

        List<int> starts = [];

        foreach (var num in set)
        {
            if(!set.Contains(num-1))
                starts.Add(num);
        }

        var longest = 0;
        foreach (var s in starts)
        {
            var n = s;
            var counter = 0;
            while (set.Contains(n))
            {
                counter += 1;
                n += 1;
            }

            longest = longest > counter ? longest : counter;
        }

        return longest;
    }
}