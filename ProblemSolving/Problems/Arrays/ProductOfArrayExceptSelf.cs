namespace ProblemSolving.Problems.Arrays;

// https://leetcode.com/problems/product-of-array-except-self/description/

public static class ProductOfArrayExceptSelf
{
    public static int[] Solution(int[] nums)
    {
        var result = new int[nums.Length];
        result[0] = 1;

        var prefix = 1;
        for (int i = 0; i < nums.Length-1; i++)
        {
            prefix *= nums[i];
            result[i+1] = prefix;
        }

        var postfix = 1;
        for (int i = nums.Length - 1; i > 0; i--)
        {
            postfix *= nums[i];
            result[i - 1] *= postfix;
        }

        return result;
    }
}