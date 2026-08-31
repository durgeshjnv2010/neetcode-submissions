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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(subRoot == null){
            return true;
        }
        if(root == null){
            return false;
        }
        if(IsSame(root, subRoot)){
            return true;
        }

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool IsSame(TreeNode t1, TreeNode t2){
        if(t1 == null && t2 == null){
            return true;
        }

        if(t1 == null || t2 == null){
            return false;
        }

        if(t1.val != t2.val){
            return false;
        }

        return IsSame(t1.left, t2.left) && IsSame(t1.right, t2.right);
    }
}
