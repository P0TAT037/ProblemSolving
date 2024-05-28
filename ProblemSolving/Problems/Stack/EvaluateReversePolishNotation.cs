namespace ProblemSolving.Problems.Stack;

// https://leetcode.com/problems/evaluate-reverse-polish-notation/description/

public static class EvaluateReversePolishNotation
{
    public static int Solution(string[] tokens)
    {
        Stack<int> stack = new();
        
        foreach (var token in tokens)
        {
            stack.Push(!int.TryParse(token, out var num) ? Eval(token) : num);
        }

        return stack.Pop();

        int Eval(string s)
        {
            switch (s)
            {
                case "+":
                    return stack.Pop() + stack.Pop();
                case "*":
                    return stack.Pop() * stack.Pop();
                case "-":
                {
                    var _2 = stack.Pop();
                    var _1 = stack.Pop();
                    return _1 - _2;
                }
                default:
                {
                    var _2 = stack.Pop();
                    var _1 = stack.Pop();
                    return _1 / _2;
                }
            }
        }
    }
}