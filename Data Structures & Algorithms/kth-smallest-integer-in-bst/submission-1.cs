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
    private int count;
    private int ans;
    public int KthSmallest(TreeNode root, int k) {
        count = k;
        InOrderTraversal(root);
        return ans;
    }
    private void InOrderTraversal(TreeNode n){
        if(n == null){
            return;
        }
        //Left traverse
        InOrderTraversal(n.left);
        count --;  //after traverse decrese counter
        if(count == 0){
            ans= n.val;
            return;
        }

        // Right traverse
        InOrderTraversal(n.right);
    }
}
