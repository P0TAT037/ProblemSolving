namespace ProblemSolving.DataStructures;

public class MergeTwoSortedLists
{
    public static ListNode Solution(ListNode list1, ListNode list2)
    {
        ListNode? result = new();
        ListNode current = result;
        
        if (list1 == null && list2 == null) return null;
        
        while (list1 != null || list2 != null) 
        {
            if(list1 == null && list2 != null)
            {
                current.val = list2.val;
                list2 = list2.next;
            }
            else if(list2 == null && list1 != null)
            {
                current.val = list1.val;
                list1 = list1.next;
            }
            else if(list1.val < list2.val) 
            {
                current.val = list1.val;
                list1 = list1.next;
            }
            else if (list2.val < list1.val)
            {
                current.val = list2.val;
                list2 = list2.next;
            }
            else
            {
                current.val = list1.val;
                
                current.next = new(list2.val);
                current = current.next;
                
                list1 = list1.next;
                list2 = list2.next;
            }
            
            if(list1 != null || list2 != null)
            {
                current.next = new();
                current = current.next;
            }
        }
        
        return result;
    }
}
