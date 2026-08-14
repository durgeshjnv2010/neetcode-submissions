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
    public bool IsBalanced(TreeNode root) {
        return Balanced(root) != -1;
    }
    public int Balanced(TreeNode root){
        if(root == null){
            return 0;
        }
        int hl = Balanced(root.left);
        if(hl == -1){
            return -1;
        }
        int hr = Balanced(root.right);
        if(hr == -1){
            return -1;
        }
        if(Math.Abs(hl-hr) > 1){
            return -1;
        }
        return Math.Max(hl,hr) +1;
    }
}
