namespace ProblemSolving.Problems.Hashmap;

// https://leetcode.com/problems/two-sum/

public static class TwoSum
{
    public static int[] Solution(int[] nums, int target)
    {
        Dictionary<int, Queue<int>> map = [];
        for (int i = 0; i< nums.Length; i++)
        {
            if(!map.TryAdd(nums[i], new([i])))
                map[nums[i]].Enqueue(i);
        }

        var result = new int[2];
        
        foreach (var n in nums)
        {
            int remaining = target - n;
            if (map.ContainsKey(remaining))
            {
                if (map[n].TryDequeue(out result[0])
                    &&
                    map[remaining].TryDequeue(out result[1]))
                {
                    return result;
                }
            }
        }

        return result;
    }
}