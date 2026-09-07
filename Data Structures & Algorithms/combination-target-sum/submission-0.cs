public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new();
        List<int> current = new();

        Backtrack(0, target);
        return result;


        void Backtrack(int start, int remaining){
            // Base condition
            if(remaining == 0){
                result.Add(new List<int>(current));
                return;
            }
            // No valid combination
            if (remaining < 0)
            {
                return;
            }

            for(int i=start; i< nums.Length; i++){
                // pick one el
                current.Add(nums[i]);

                // explore---why i, becz self kitni baar bhi aa sakta h
                Backtrack(i, remaining-nums[i]);

                // remove
                current.RemoveAt(current.Count-1);
            }
        }
    }
}
