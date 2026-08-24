public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length)
            return "";
        Dictionary<char, int> tmap = new();


        for(int i=0; i< t.Length; i++){
            if(!tmap.ContainsKey(t[i])){
                tmap[t[i]]=0;
            }
            tmap[t[i]]++;
        }

        Dictionary<char, int> winfr = new();
        int left=0;
        int right=0;

        int formed =0;  // how many chars achieved it frequency
        int required=tmap.Count;

        int minLength = int.MaxValue;
        int minStart = 0;

        while(right< s.Length){
            //// Add right character to window
            char c = s[right];

            if (!winfr.ContainsKey(c))
                winfr[c] = 0;

            winfr[c]++;
            // Did this character just satisfy a requirement?
            if(tmap.ContainsKey(c) && tmap[c] == winfr[c]){
                formed++;
            }
            // Current window is valid
            while(formed==required){
                //         save current window if smaller
                // remove s[left]
                // if removing it breaks a requirement:
                //     formed--
                // left++
                // Save smallest valid window
                int winl = right-left+1;
                if(winl<minLength){
                    minLength=winl;
                    minStart=left;
                }
                // Remove left character
                char lc = s[left];
                winfr[lc]--;

                // Did removing it break a requirement?
                if(tmap.ContainsKey(lc) && winfr[lc] < tmap[lc]){
                    formed--;
                }
                left++;
            }




            right++;
        }
        if (minLength == int.MaxValue)
            return "";
        return s.Substring(minStart,minLength);
    }
}
