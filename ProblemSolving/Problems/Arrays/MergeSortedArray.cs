namespace ProblemSolving.Problems.Arrays;

// https://leetcode.com/problems/merge-sorted-array/?envType=study-plan-v2&envId=top-interview-150
public static class MergeSortedArray
{
    public static void Solution(int[] nums1, int m, int[] nums2, int n)
    {
        var n1 = m - 1;
        var n2 = n - 1;
        var s = m + n - 1;

        while (n2 >= 0)
        {

            if (n1 >= 0 && nums1[n1] > nums2[n2])
            {
                nums1[s] = nums1[n1];
                s--;
                n1--;
            }
            else
            {
                nums1[s] = nums2[n2];
                s--;
                n2--;
            }
        }

    }
}
