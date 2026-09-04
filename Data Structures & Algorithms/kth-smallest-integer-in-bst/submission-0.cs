/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    private int c;
    public int KthSmallest(TreeNode root, int k) {
        c = k;
        return InOrderTraversal(root);
    }
    private int InOrderTraversal(TreeNode n){
        if(n == null){
            return -1;
        }

        // Left me check first 
        int t = InOrderTraversal(n.left);
        if(c==0){
            return t;
        }
        c--;

        //Node element check

        if(c ==0){
            return n.val;
        } 

        // Right me check
        return InOrderTraversal(n.right);
    }
}
