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
    private Dictionary<int, int> map;
    private int preorderindex;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        // 1. Preorder ka first element = root
        // 2. Inorder mein root ki position find karo
        // 3. Left aur right subtree recursively banao

        // To find index in preorder list, make dictionary
        map = new();
        for (int i=0; i<inorder.Length; i++){
            map[inorder[i]] = i;
        }
        preorderindex=0;
        return Build(preorder, 0, inorder.Length-1);

    }

    private TreeNode Build(int[] preorder, int left, int right)
    {
        if(left>right){
            return null;
        }

        // preorder ka next element root hoga
        int val = preorder[preorderindex++];
        TreeNode t = new TreeNode(val, null, null);

        // Inorder mein root ki position
        int mid = map[val];

        // add left subtree
        t.left = Build(preorder, left,mid-1 );


        // add right subtree
        t.right = Build(preorder, mid+1, right);


        return t;

    }
}
