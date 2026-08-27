public class Solution {
    public int FindMin(int[] nums) {
        // Binary search lagao
        // if right element is smaller than mid then smallest element right side me hoga
        // else, mid el min hoga or left array me milega

        int left =0;
        int right = nums.Length-1;

        while(left<right){
            int mid = left + (right-left)/2;
            if(nums[mid] > nums[right]){
                // min el in right array
                left = mid+1;
            }
            else{
                right = mid;
            }
        }

        return nums[left];
    }
}
