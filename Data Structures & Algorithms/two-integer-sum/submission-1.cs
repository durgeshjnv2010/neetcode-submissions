public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new();

        for(int i =0; i< nums.Length; i++){
            int fn = nums[i];
            int sn = target-fn;

            if(map.ContainsKey(sn)){
                return [map[sn], i];
            }
            else{
                map[fn] = i;
            }
        }
        return null;
    }
}
