public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        List<List<int>> result = new();
        List<int> current = new();
        Array.Sort(nums); // for duplicate identification array should be sorted
        Backtrack(0);

        return result;

        void Backtrack(int start){
            result.Add(new List<int>(current));

            for(int i=start; i< nums.Length;i++){
                // base cond, i == i-1 then skip i

                if(i > start && nums[i] == nums[i-1]){
                    continue;
                }

                current.Add(nums[i]);
                Backtrack(i+1);

                current.RemoveAt(current.Count-1);
            }
        }
    }
}
