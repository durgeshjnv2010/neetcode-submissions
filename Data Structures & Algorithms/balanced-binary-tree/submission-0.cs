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
        // at each node  height of ltree and righttree differ by max 1
        // every subtree should be balanced as well
        return Height(root) != -1;

    }
    private int Height(TreeNode t){
        if( t == null){
            return 0;
        }

        int lh = Height(t.left);
        if(lh == -1){
            return -1;
        }

        int rh = Height(t.right);
        if(rh == -1){
            return -1;
        }

        // if current node is unbalanced
        if(Math.Abs(lh-rh) > 1){
            return -1;
        }

        return 1 + Math.Max(lh, rh);
    }
}
