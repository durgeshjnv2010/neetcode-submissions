public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        //Aproach 2: freqency of each char in s1 matches frequency of char in s2 matches in each window 
        if(s1.Length > s2.Length){
            return false;
        }
        int[] s1f = new int[26];
        int[] s2wf = new int[26];
        for(int i=0; i<s1.Length; i++){
            s1f[s1[i]-'a'] ++;

            // Lets fill first window
            s2wf[s2[i]-'a'] ++;
        }
        if(AreSame(s1f, s2wf)){
            return true;
        }

        int left = 0;
        // Current window already full kiya
        for(int right= s1.Length; right < s2.Length; right++){
            // first add el
            s2wf[s2[right]-'a'] ++;
            // remove old char to keep window size equal to s1
            s2wf[s2[left]-'a'] --;

            left++;

            if(AreSame(s1f, s2wf)){
                return true;
            }
        }
        return false;



    }

    private bool AreSame(int[] a, int[] b){
        for(int i=0; i<26; i++){
            if(a[i] != b[i]){
                return false;
            }
        }
        return true;
    }
}
