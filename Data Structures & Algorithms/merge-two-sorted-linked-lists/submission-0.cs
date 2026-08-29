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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        // Fake starting node.
        // It removes the special case of creating the first node.
        ListNode dummy = new ListNode(0);

        // tail always points to the last node
        // in our merged list.
        ListNode tail = dummy;

        while(list1 != null && list2 != null){
            if(list1.val <= list2.val){
                // Attach list1's current node
                tail.next = list1;
                // Move list1 forward
                list1 = list1.next;
            }
            else{
                // Attach list2's current node
                tail.next = list2;

                // Move list2 forward
                list2 = list2.next;
            }
            // Move tail to the newly added node
            tail = tail.next;
        }
        // One list is finished.
        // Attach whatever remains.
        tail.next = list1 ?? list2;

        // Skip fake dummy node.
        return dummy.next;
    }
}