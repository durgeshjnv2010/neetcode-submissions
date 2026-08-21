public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // Its 1 index based arr not 0
        // a+b = target
        // l+r > target => move right towards left
        // l+r <target  => move left towards right

        int left =0;
        int right=numbers.Length-1;

        while (left<right){
            while(left<right && (numbers[left] + numbers[right] > target)){
                right--;
            }
            while(left<right && (numbers[left] + numbers[right] < target)){
                left++;
            }
            if(numbers[left] + numbers[right] == target){
                return [left+1, right +1];
            }
        }
        return [];
    }
}
