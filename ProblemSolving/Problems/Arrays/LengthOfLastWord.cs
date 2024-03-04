using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Arrays;

// https://leetcode.com/problems/length-of-last-word/?envType=study-plan-v2&envId=top-interview-150

public class LengthOfLastWord
{
    public static int Solution(string s)
    {
        s = s.TrimEnd();
        int c = 0;
        for(int i = s.Length-1; i > -1; i--)
        {
            if (char.IsWhiteSpace(s[i]))
                break;
            c++;
        }
        
        return c;
    }
}
