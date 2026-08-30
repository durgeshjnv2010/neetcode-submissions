public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> map = new();

        for (int i=0; i<nums.Length; i++){
            if(map.Contains(nums[i])){
                return nums[i];
            }
            else{
                map.Add(nums[i]);
            }

        }
        return -1;
    }
}
