public class Solution {
    public int LengthOfLongestSubstring(string s) {
        char[] arr= s.ToCharArray();
        Dictionary<char, int> map = new();
        int l = 0; // Sliding window me left pointer
        int maxl = 0;
        for(int i=0;i<arr.Length; i++){
            
            if(map.ContainsKey(arr[i])){
                // Move left pointer after previous occurance
                l = Math.Max(l, map[arr[i]]+1);
            }
            // Update Current char latest position
            map[arr[i]]=i;
            // Current windo = [l......i]
            maxl = Math.Max(i-l+1, maxl);
        }
        return maxl;
    }
}
