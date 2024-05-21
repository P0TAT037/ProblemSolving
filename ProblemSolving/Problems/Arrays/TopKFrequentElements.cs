namespace ProblemSolving.Problems.Arrays;

// https://leetcode.com/problems/top-k-frequent-elements/description/

public static class TopKFrequentElements
{
    public static int[] Solution(int[] nums, int k)
    {
        Queue<int>[] sortBucket = new Queue<int>[nums.Length];
        Dictionary<int, int> freq = [];
        foreach (var n in nums)
        {
            if (!freq.TryAdd(n, 1))
                freq[n]++;
        }

        foreach (var entry in freq)
        {
            if (sortBucket[entry.Value-1] == null)
                sortBucket[entry.Value-1] = new Queue<int>();
            sortBucket[entry.Value-1].Enqueue(entry.Key);
        }

        int[] result = new int[k];
        var qNum = sortBucket.Length-1;
        var q = sortBucket[qNum];
        for (var i = 0; i < k; i++)
        {
            while (q is null || q.Count== 0)
            {
                qNum -= 1;
                q = sortBucket[qNum];
            }

            result[i]=q.Dequeue();
        }

        return result;
    }
}