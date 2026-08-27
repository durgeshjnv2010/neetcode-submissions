public class Solution {
    public int Search(int[] nums, int target) {
        int left =0;
        int right = nums.Length-1;
        while(left <= right){
            int mid = left + (right-left)/2;
            // Trick: every iteration one sub array will be in sorted array
            // how to check which is sorted
            // if nums[left]<=nums[mid] then left half sorted h
            if(nums[mid] == target){
                return mid;
            }
            if(nums[left]<=nums[mid]){
                // target left me h
                if(target<nums[mid] && target >= nums[left]){
                    right=mid-1;
                }
                else{
                    left=mid+1;
                }
                

            }
            else{
                // right sub array sorted h
                if(target>nums[mid] && target <= nums[right]){
                    left = mid+1;
                }
                else{
                    right=mid-1;
                }
            }
        }
        return -1;
    }
}
