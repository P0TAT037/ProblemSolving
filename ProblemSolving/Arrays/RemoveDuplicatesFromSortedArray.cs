namespace ProblemSolving.Arrays;

// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/?envType=study-plan-v2&envId=top-interview-150
public class RemoveDuplicatesFromSortedArray
{
    public static int Solution(int[] nums)
    {
        int j = 1;
        for(int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i-1])
            {
                nums[j] = nums[i];         
                j++;
            }
            
        
        }
        
        return j;
    }
}
