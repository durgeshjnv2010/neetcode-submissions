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
    public List<int> RightSideView(TreeNode root) {
        // levelsize-1 wala element right wala hoga, index 0 based h isliye

        if(root == null){
            return [];
        }
        List<int> list = new();
        Queue<TreeNode> q = new();
        q.Enqueue(root);

        while(q.Count > 0){
            int levelsize = q.Count;
            for(int i=0; i< levelsize; i++){
                TreeNode t = q.Dequeue();

                if(i == levelsize-1){
                    list.Add(t.val);
                }

                if(t.left != null){
                    q.Enqueue(t.left);
                }
                if(t.right != null){
                    q.Enqueue(t.right);
                }
            }
        }
        return list;
    }
}
