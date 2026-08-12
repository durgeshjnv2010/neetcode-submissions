public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numset = new HashSet<int> (nums);

        int longest = 0;
        foreach (int num in numset) 
        {
            int length = 1;
            while (numset.Contains(num+length))
            {
                length++;
            }       
            longest = Math.Max(longest, length);
        }
        return longest;
    }
}
