public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<List<int>> result = new();
        List<int> current = new();
        Array.Sort(candidates);
        Backtrack(0, target);

        return result;

        void Backtrack(int start, int remaining){
            // base cond
            if(remaining == 0){
                result.Add(new List<int>(current));
                return;
            }
            if(remaining < 0){
                return;
            }

            for(int i=start; i<candidates.Length; i++){
                // duplicate ko avoid kro
                if(i>start && candidates[i] == candidates[i-1]){
                    continue;
                }
                // Optional pruning because array sorted hai
                if(remaining < candidates[i]){
                    break;
                }
                // pick one el
                current.Add(candidates[i]);

                // explore
                Backtrack(i+1, remaining-candidates[i]);

                // remove
                current.RemoveAt(current.Count-1);
            }
        }
    }
}
