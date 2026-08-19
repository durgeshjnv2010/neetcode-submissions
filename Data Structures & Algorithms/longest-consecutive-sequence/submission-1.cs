public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new(nums);
        int longest = 0;
        foreach(int n in set){
            if(!set.Contains(n-1)){
                int current = n;
                int length = 1;
                while(set.Contains(current+1)){
                    current++;
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }
        return longest;
    }
}
