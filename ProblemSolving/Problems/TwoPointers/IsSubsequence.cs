namespace ProblemSolving.Problems.TwoPointers;

// https://leetcode.com/problems/is-subsequence/description/?envType=study-plan-v2&envId=top-interview-150
public class IsSubsequence
{
    public static bool Solution(string s, string t)
    {
        if (string.IsNullOrEmpty(s))
            return true;

        if (string.IsNullOrEmpty(t))
            return false;

        int j = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == s[j])
            {
                if (++j == s.Length)
                    return true;
            }
        }

        return false;
    }
}
