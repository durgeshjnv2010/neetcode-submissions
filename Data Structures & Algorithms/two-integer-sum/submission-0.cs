public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int, int> dictObject = new Dictionary<int, int>();

        for (int i=0; i< nums.Length; i++){
            int diff = target- nums[i];

            if(dictObject.ContainsKey(diff)){
                return new int[2]{dictObject[diff], i};
            }
            dictObject[nums[i]] = i;
        }

        return null;
    }
}
