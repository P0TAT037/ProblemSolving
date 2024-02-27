using ProblemSolving.DataStructures;

namespace ProblemSolving.Problems.LinkedLists;

// https://leetcode.com/problems/linked-list-cycle/description/?envType=study-plan-v2&envId=top-interview-150

public class LinkedListCycle
{
    public static bool Solution(ListNode head)
    {
        if (head == null) return false;

        var current = head;
        var visitedNodes = new HashSet<ListNode>();
        while (current.next != null)
        {
            visitedNodes.Add(current);
            if(visitedNodes.Contains(current.next))
                return true;
            current = current.next;
        }

        return false;
    }

    // two pointers
    public static bool Solution2(ListNode head)
    {
        if (head == null) return false;

        var fastPtr = head;
        var slowPtr = head;
        while (fastPtr != null && fastPtr.next != null) 
        {
            slowPtr = slowPtr.next;
            fastPtr = fastPtr.next.next;
            if(slowPtr == fastPtr) return true;
        }
        
        return false;
    }
}
