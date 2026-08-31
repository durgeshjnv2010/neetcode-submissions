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
    public int MaxDepth(TreeNode root) {
        if(root == null){
            return 0;
        }

        Queue<TreeNode> q = new();
        int depth = 0;

        q.Enqueue(root);
        while(q.Count > 0){
            int levelsize = q.Count;
            for(int i=0; i < levelsize; i++){
                TreeNode t = q.Dequeue();
                if(t.left != null){
                    q.Enqueue(t.left);
                }
                if(t.right != null){
                    q.Enqueue(t.right);
                }
            } 
            depth++;
        }

        return depth;
    }
}
