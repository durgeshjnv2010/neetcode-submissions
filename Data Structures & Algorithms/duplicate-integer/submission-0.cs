public class Solution {
    public bool hasDuplicate(int[] nums) {

        // Prepare Frequency Map
        Dictionary<int, int>  count = new();
        for(int i=0; i< nums.Length; i++){
            if(!count.ContainsKey(nums[i])){
                count[nums[i]] = 0;
            }
            count[nums[i]]++;
        }

        // Now check if el which has frq more than 1
        foreach(var kv in count){
            if(kv.Value > 1){
                return true;
            }
        }
        return false;
    }
}