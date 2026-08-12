public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> values = [];
        for (int i =0; i< nums.Length; i++)
        {
            int fn = nums[i];
            int sn = target-fn;
            if (values.ContainsKey(sn))
            {
                return [values[sn], i];
            }
            else
            {
                values.Add(fn, i);
            }
        }
        return null;
    }
}
