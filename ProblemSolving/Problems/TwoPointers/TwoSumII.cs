namespace ProblemSolving.Problems.TwoPointers;

// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/

public static class TwoSumII
{
    public static int[] Solution(int[] numbers, int target) {
        var i1 = 0;
        var i2 = numbers.Length-1;

        while ((i1 != i2))
        {
            if (numbers[i1] + numbers[i2] == target)
                return [i1 + 1, i2 + 1];
            
            if(numbers[i1] + numbers[i2] < target) 
                i1++;
            else if (numbers[i1] + numbers[i2] > target)
                i2--;
        }

        return [];
    }
}