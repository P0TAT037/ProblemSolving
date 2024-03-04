namespace ProblemSolving.Problems.Arrays;

// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/?envType=study-plan-v2&envId=top-interview-150

public class FirstOccurence
{
    public static int Solution(string haystack, string needle)
    {
        if(haystack.Length < needle.Length)
            return -1;

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                if(haystack.Substring(i, needle.Length) == needle)
                    return i;
            }
            
        }
        return -1;
    }
}
