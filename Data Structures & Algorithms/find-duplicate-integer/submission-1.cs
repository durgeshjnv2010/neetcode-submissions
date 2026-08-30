public class Solution {
    public int FindDuplicate(int[] nums) {
        int slow = nums[0];
        int fast = nums[0];

        // slow fast dono same point se chal rhe to do while lagao else kabhi execute nhoga
        do{
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        while(slow != fast);
        // After this fast will at meeting point with slow

        slow = nums[0];
        while(slow != fast){
            slow=nums[slow];
            fast = nums[fast];
        }
        return slow;

    }
}
