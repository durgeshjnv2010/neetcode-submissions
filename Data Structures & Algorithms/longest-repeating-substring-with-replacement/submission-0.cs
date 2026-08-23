public class Solution {
    public int CharacterReplacement(string s, int k) {
        // Sliding window + frequency
        Dictionary<char,int> freq= new();
        int left=0;
        int maxl = 0;
        int maxf = 0;
        for(int right=0;right<s.Length;right++){
            // first update frequency of each char
            if(!freq.ContainsKey(s[right])){
                freq[s[right]] = 0;
            }
            freq[s[right]]++;

            // Highest freq char in current window
            maxf=Math.Max(maxf, freq[s[right]]);

            // How many chars do we need to replace
            int windowl= right-left+1;
            int replacecount = windowl - maxf;

            // To many replacement -> shrink window
            if(replacecount > k){
                freq[s[left]]--;
                left++;
            }

            // Now current window valid, so cal maxl
            maxl= Math.Max(maxl, right-left+1);

        }
        return maxl;
    }
}
