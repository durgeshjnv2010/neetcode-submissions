public class Solution {
    public int LongestConsecutive(int[] nums) {
        // First lets find which is first element: Element n whose n-1 doesnt exit
        // Then iterate from n to n+x where n+x exists in set and increase counter with each true exist

        int longest = 0;
        HashSet<int> set = new(nums);
        foreach(int n in nums){

            if(!set.Contains(n-1)){ // First lets find which is first element: Element n whose n-1 doesnt exit
                int current =n ;
                int len = 1;
                while(set.Contains(current+1)) //iterate from n to n+x where n+x exists in set and increase counter with each true exist
                {
                    current++;
                    len++;
                }
                longest = Math.Max(longest, len); // Upon completion of 1st iteration updated longest based on what len was captured
            }
        }

        return longest;
    }
}
