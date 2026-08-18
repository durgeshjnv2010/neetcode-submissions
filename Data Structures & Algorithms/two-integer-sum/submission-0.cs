public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        /// target = x + y
        /// y =  target - x
        /// Keep one dict map
        Dictionary<int, int> map = new();
        for(int i =0; i< nums.Length; i++){
            int second = target-nums[i];
            
            if(map.ContainsKey(second)){
                return [map[second], i];
            }
            map[nums[i]] = i;
        }
        return [];
    }
}
