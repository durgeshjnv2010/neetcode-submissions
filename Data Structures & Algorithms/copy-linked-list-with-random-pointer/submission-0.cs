/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        // Using dictionary
        if(head == null){
            return null;
        }
        Dictionary<Node, Node> map = new();

        Node curr = head;
        while(curr != null){
            map[curr] = new Node(curr.val);
            curr = curr.next;
        }
        // Now connect next and random pointers
        curr=head;
        while(curr != null){
            map[curr].next = curr.next == null ? null : map[curr.next];

            map[curr].random = curr.random == null ? null : map[curr.random];
            curr = curr.next;
        }

        return map[head];
    }
}
