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
    public ListNode ReverseList(ListNode head) {
        ListNode prv = null;
        ListNode curr = head;
        
        while(curr != null){
            ListNode next = curr.next;
            curr.next = prv;
            prv = curr;
            curr = next;
        }
        head = prv;
        return head;
    }
}
