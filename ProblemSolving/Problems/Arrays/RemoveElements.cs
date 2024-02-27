namespace ProblemSolving.Problems.Arrays;

// https://leetcode.com/problems/remove-element/description/?envType=study-plan-v2&envId=top-interview-150
public class RemoveElements
{
    public static int Solution(int[] nums, int val)
    {
        int offset = 0;
        for (int i = 0; i < nums.Length - offset; i++)
        {

            while (nums[i + offset] == val)
            {
                offset++;
                if (i + offset == nums.Length)
                    return nums.Length - offset;
            }


            nums[i] = nums[i + offset];


        }

        return nums.Length - offset;
    }

    public static int Solution2(int[] nums, int val)
    {
        int j = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[j] = nums[i];
                j++;
            }
        }

        return j;
    }
}
