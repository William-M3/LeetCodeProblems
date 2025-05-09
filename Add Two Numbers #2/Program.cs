/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode();
        ListNode current = dummy;
        int overflow = 0;

        while (l1 != null && l2 != null)
        {
            l1.val = l1.val + l2.val + overflow;
            if (l1.val > 9)
            {
                l1.val = l1.val % 10;
                overflow = 1;
            }
            else
            {
                overflow = 0;
            }
            current.next = l1;
            current = l1;
            l1 = l1.next;
            l2 = l2.next;
        }

        while(l1 != null)
        {
            if (overflow == 0)
            {
                current.next = l1;
                break;
            }

            l1.val = l1.val + overflow;

            if (l1.val > 9)
            {
                l1.val = l1.val % 10;
                overflow = 1;
                current.next = l1;
                current = l1;
                l1 = l1.next;
            }
            else
            {
                overflow = 0;
                current.next = l1;
                break;
            }

        }

        while(l2 != null)
        {
            if (overflow == 0)
            {
                current.next = l2;
                break;
            }

            l2.val = l2.val + overflow;
            
            if(l2.val > 9)
            {
               l2.val = l2.val % 10;
               overflow = 1;
               current.next = l2;
               current = l2;
               l2 = l2.next; 
            }
            else
            {
                overflow = 0;
                current.next = l2;
                break;
            }
        }
        
        if (overflow == 1)
        {
            current.next = new ListNode();
            current = current.next;
            current.val = 1;
        }

        return dummy.next;
    }
}