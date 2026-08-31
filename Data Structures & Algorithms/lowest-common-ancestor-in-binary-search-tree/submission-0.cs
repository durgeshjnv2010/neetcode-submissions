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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
//         p and q dono root se chhote
//         ↓
//          left jao

//          p and q dono root se bade
//         ↓
//          right jao

//          otherwise
//         ↓
//          current root hi LCA hai

        if(p.val < root.val && q.val < root.val){
            return LowestCommonAncestor(root.left, p, q);
        }
        if(p.val > root.val && q.val > root.val){
            return LowestCommonAncestor(root.right, p, q);
        }
        return root;



    }
}
