namespace ProblemSolving.DataStructures;

// https://leetcode.com/problems/min-stack/description/

public class MinStack
{
    Stack<int> stack;
    private Stack<int> mins;
    private int lastMin;
    public MinStack()
    {
        stack = new();
        mins = new();
        lastMin = int.MaxValue;
    }
    
    public void Push(int val)
    {
        stack.Push(val);
        if (stack.Count == 0)
        {
            lastMin = val;
        }
        else
        {
            lastMin = val < lastMin ? val : lastMin;
        }
        mins.Push(lastMin);
    }
    
    public void Pop()
    {
        stack.Pop();
        mins.Pop();
        if(!mins.TryPeek(out lastMin))
            lastMin = Int32.MaxValue;
    }
    
    public int Top()
    {
        return stack.Peek();
    }
    
    public int GetMin()
    {
        return mins.Peek();
    }
}