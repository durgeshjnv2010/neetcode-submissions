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
    public List<List<int>> LevelOrder(TreeNode root) {
        // each level pe queue me insert 
        if(root == null){
            return [];
        }
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        List<List<int>> list = new();
        while(q.Count >0){
            int levelsize = q.Count;
            // New list for current level
            List<int> currentLevel = new();

            for(int i =0; i< levelsize; i++){
                TreeNode t = q.Dequeue();
                
                currentLevel.Add(t.val);

                if(t.left != null){
                    q.Enqueue(t.left);
                }
                if(t.right != null){
                    q.Enqueue(t.right);
                }
                
            }
            list.Add(currentLevel);
        }
        return list;
    }
}
