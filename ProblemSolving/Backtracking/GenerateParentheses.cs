namespace ProblemSolving.Backtracking;

// https://leetcode.com/problems/generate-parentheses/description/

public static class GenerateParentheses
{
    private static string s = "";
    
    public static IList<string> Solution(int n)
    {
        List<string> list = new();
        Gen(0,0);
        return list;
        
        void Gen(int open, int closed)
        {
            if (open == closed && closed == n)
            {
                list.Add(s);
                s = "";
                return;
            }

            if (open < n)
            {
                s+='(';
                Gen(open+1, closed);
                if(!string.IsNullOrEmpty(s))
                    s = s.Remove(s.Length-1);
            }

            if (closed < open)
            {
                s+=')';
                Gen(open, closed+1);
                if(!string.IsNullOrEmpty(s))
                    s = s.Remove(s.Length-1);
            }
        }

    }
    
}