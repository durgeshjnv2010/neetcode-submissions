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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // make dummy node befor head so that head wala case is covered
        // second pinter will ne at gap of n+1
        // so that second pointer null ko point karega tab, dummy node remove karne 
        // wale element ke pahle hoga
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode left = dummy;
        ListNode right = dummy;

        for(int i =0;i<=n;i++){
            right = right.next;
        }
        // ab right jab null ko point karega tab left target se pahle pahle wale ko point kareag
        while(right != null){
            left= left.next;
            right = right.next;
        }
        left.next = left.next.next;

        return dummy.next;

    }
}
