using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Stack;

// https://leetcode.com/problems/valid-parentheses/description/?envType=study-plan-v2&envId=top-interview-150

public class ValidParentheses
{
    public static bool Solution(string s)
    {
        Stack<char> stack = new Stack<char>();
        char top;
        char? closingChar;
        
        foreach (char c in s)
        {

            stack.TryPeek(out top);
            closingChar = 'a';
            
            if (top == '(')
                closingChar = ')';
            
            else if (top == '{')
                closingChar = '}';
            
            else if (top == '[')
                closingChar = ']';
            
            if (c == closingChar)
                stack.TryPop(out _);
            else
                stack.Push(c);
            
        }
        
        return stack.Count == 0;
    }
}
