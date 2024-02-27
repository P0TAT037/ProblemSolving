
namespace ProblemSolving.DataStructures;



public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}


public class LinkedList
{
    public ListNode Head = new();
    public ListNode Current;
    public LinkedList(int[] elements)
    {
        if (elements.Length == 0)  return;

        Current = Head;

        foreach (int element in elements)
        {
            Current.val = element;
            Current.next = new();
            Current = Current.next;
        }
        Current = Head;
    }
}

