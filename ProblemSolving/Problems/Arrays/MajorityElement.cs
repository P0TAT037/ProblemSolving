namespace ProblemSolving.Problems.Arrays;

// https://leetcode.com/problems/majority-element/description/?envType=study-plan-v2&envId=top-interview-150

public class MajorityElement
{
    public static int Solution(int[] nums)
    {
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }

    // Hashmap
    public static int Solution2(int[] nums)
    {
        Dictionary<int, int> map = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.TryAdd(nums[i], 1))
                map[nums[i]]++;
        }

        foreach (int k in map.Keys)
        {
            if (map[k] > nums.Length / 2)
                return k;
        }

        return -1;
    }

    // Moore's voting algorithm
    public static int Solution3(int[] nums)
    {
        int n = 0;
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                n = nums[i];
                count++;
            }
            else if (n == nums[i])
                count++;
            else
                count--;
        }


        // if the array is not gauranteed to have majority element
        // we will have to check our resulting candidate element before returning it

        //count = 0;
        //for(int i = 0;i < n; i++)
        //{
        //    if (nums[i] == n )
        //        count++;
        //}
        //if (count < nums.Length / 2)
        //    return -1;

        return n;
    }
}
