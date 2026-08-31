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
    private int dia = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        GetHeight(root);

        return dia;
    }
    // to get height at each node
    private int GetHeight(TreeNode t){
        if(t == null){
            return 0;
        }
        int hl = GetHeight(t.left);
        int hr = GetHeight(t.right);

        dia = Math.Max(dia, hl+hr);
        return 1+ Math.Max(hl,hr);
    }
}
