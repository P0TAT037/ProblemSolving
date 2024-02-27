using System.Collections;

namespace ProblemSolving.Problems.Arrays;

// https://leetcode.com/problems/roman-to-integer/?envType=study-plan-v2&envId=top-interview-150

public class RomanToInt
{
    public static int Solution(string s)
    {
        Hashtable conversion = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        int sum = 0;
        int num;
        int lastAdded = (int)conversion[s[s.Length - 1]]!;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            num = (int)conversion[s[i]]!;

            if (num < lastAdded)
            {
                sum -= num;
            }
            else
            {
                sum += num;
            }

            lastAdded = num;
        }

        return sum;
    }
}
