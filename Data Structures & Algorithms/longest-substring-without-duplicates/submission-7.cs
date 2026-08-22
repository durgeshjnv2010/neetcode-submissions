public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        Dictionary<char, int> map = new();
        char[] arr= s.ToCharArray();
        int lmax=0;
        int l =0; // left pointer of sliding window
        for(int i=0;i<arr.Length;i++){
            if(map.ContainsKey(arr[i]) && map[arr[i]] >= l){
                l = map[arr[i]]+1;
            }
            map[arr[i]] = i;
            lmax = Math.Max(i-l+1, lmax);
        }
        return lmax;





        // char[] arr= s.ToCharArray();
        // Dictionary<char, int> map = new();
        // int l = 0; // Sliding window me left pointer
        // int maxl = 0;
        // for(int i=0;i<arr.Length; i++){
            
        //     if(map.ContainsKey(arr[i])){
        //         // Move left pointer after previous occurance
        //         //Duplicate b ko remove karne ke liye l ko previous b ke just baad le jaana hai:
        //         // l should never go back
        //         l = Math.Max(l, map[arr[i]]+1);
        //     }
        //     // Update Current char latest position
        //     map[arr[i]]=i;
        //     // Current windo = [l......i]
        //     maxl = Math.Max(i-l+1, maxl);
        // }
        // return maxl;
    }
}
