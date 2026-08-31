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
    public TreeNode InvertTree(TreeNode root) {
        //Har node ka left child aur right child swap karo.

        if(root == null){
            return null;
        }
        // Swap left and right
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;

        // now invert each child tree
        InvertTree(root.left);
        InvertTree(root.right);

        return root;
    }
}
