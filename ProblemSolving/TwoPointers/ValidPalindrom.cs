namespace ProblemSolving.TwoPointers;

// https://leetcode.com/problems/valid-palindrome/?envType=study-plan-v2&envId=top-interview-150
public class ValidPalindrom
{
    public static bool Solution(string s)
    {
        s = s.ToLower();
        string ss = "";
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                ss += c;
            }
        }
        
        int i = 0;
        int j = (ss.Length == 0) ? 0 : ss.Length-1;

        while (i < j)
        {
            if (ss[i] != ss[j])
                return false;
        
            i++;
            j--;
        }
        
        return true;
    }
    
    public static bool Solution2(string s)
    {
        s = s.ToLower();
        
        int i = 0;
        int j = (s.Length == 0) ? 0 : s.Length-1;

        while (i < j)
        {
            
            if (!char.IsLetterOrDigit(s[i]))
            {
                i++;
                continue;
            }
            
            if (!char.IsLetterOrDigit(s[j]))
            {
                j--;
                continue;
            }
            
            if (s[i] != s[j])
                return false;
        
            i++;
            j--;
        }
        
        return true;
    }
    
}
