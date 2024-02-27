
namespace ProblemSolving.DataStructures;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode() { }
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

public class LinkedList
{
    public ListNode Head = new();
    public ListNode? Current;
    public LinkedList(int[] elements)
    {
        Current = Head;
        foreach (int element in elements)
        {
            Current = new ListNode(element);
            Current = Current.next;
        }
        Current = Head;
    }
}

