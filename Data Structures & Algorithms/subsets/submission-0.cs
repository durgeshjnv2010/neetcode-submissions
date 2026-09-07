public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        // Backtracking = Decision Tree + DFS + Undo


        List<List<int>> result = new();
        List<int> current = new();
        Backtrack(0);

        return result;

        void Backtrack(int start){
            // add current to result else, current mutate hota rhega
            result.Add(new List<int>(current));

            for(int i=start; i<nums.Length;i++){
                // pick one element
                current.Add(nums[i]);

                // explore
                Backtrack(i+1);

                // remove
                current.RemoveAt(current.Count-1);
            }
            
        }
    }
}
