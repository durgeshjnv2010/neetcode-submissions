public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new();
        List<int> current = new();
        bool[] used = new bool[nums.Length];
        Backtrack();

        return result;

        void Backtrack(){
            // base condition current.Length == nums.Length
            
            if(current.Count == nums.Length){
                result.Add(new List<int>(current));
                return;
            }

            for(int i=0; i< nums.Length; i++){
                //pick one el
                // Already used
                if (used[i])
                    continue;
                current.Add(nums[i]);
                used[i] = true;
                // explore
                Backtrack();

                //remove
                used[i] = false;
                current.RemoveAt(current.Count-1);


            }
        }
    }
}
