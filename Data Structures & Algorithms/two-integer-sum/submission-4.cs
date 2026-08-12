public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = [];
        for(int i =0; i < nums.Length; i++){
            int firstNumber = nums[i];
            int secondNumber = target-firstNumber;
            if(map.ContainsKey(secondNumber)){
                return [map[secondNumber], i];
            }
            else{
                map.Add(firstNumber, i);
            }
        }

        return [];
    }
}
