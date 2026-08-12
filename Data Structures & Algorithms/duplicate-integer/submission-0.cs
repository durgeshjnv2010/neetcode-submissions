public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> input = new HashSet<int>();
        
        for(int i =0; i < nums.Length; i++){
            if(input.Contains(nums[i])){
                return true;
            }
            else{
                input.Add(nums[i]);
            }
            
        }
        return false;
    }
}
