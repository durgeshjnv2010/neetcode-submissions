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
    public void ReorderList(ListNode head) {
        if(head == null || head.next == null){
            return;
        }

        // First find middle
        // slow node and fast node
        // when fast node is null then slow will point at middle
        ListNode slow = head;
        ListNode fast = head;
        while(fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast= fast.next.next;
        }

        // Split the list
        ListNode second = slow.next; // This will store 2nd half
        slow.next = null; // original list has only first half


        // Reverse 2nd list
        ListNode curr = second;
        ListNode prv = null;
        while(curr != null){
            //First Store next node before reversing pointer
            ListNode nxt = curr.next;  // store next pointer
            curr.next = prv; // curr ka pointer reverse
            prv = curr; // prv ko curr pe lao from null
            curr = nxt; // curr ko next pe move karo
        }
        second = prv;  // Head assging to org


        // Merge slow and second
        ListNode first = head;
        while(second != null){
            ListNode firstnext = first.next;
            ListNode secondnext = second.next;

            first.next = second;
            second.next = firstnext;

            first = firstnext;
            second = secondnext;

        }

    }
}
