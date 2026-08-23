public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        // s1 length = fixed window size for s2 traverse
        if(s1.Length>s2.Length){
            return false;
        }
        Dictionary<char, int> s1map= new();
        Dictionary<char, int> s2map= new();

        //Prepare s1 map to compare with each window of s2
        for(int i=0; i<s1.Length; i++){
            if(!s1map.ContainsKey(s1[i])){
                s1map[s1[i]]=0;
            }
            s1map[s1[i]]++;
        }
        int left =0;
        for(int i=0;i<s2.Length;i++){
            //s2 map prepare
            if(!s2map.ContainsKey(s2[i])){
                s2map[s2[i]]=0;
            }
            s2map[s2[i]]++;

            //If window larger than s1.Length then shrink window
            // left++, s2map[s2[left]]-- and if s2map[s2[left]] == 0 then remove s2[left]
            int winl=i-left+1;
            if(winl> s1.Length){
                s2map[s2[left]]--;
                if(s2map[s2[left]] == 0){
                    s2map.Remove(s2[left]);
                }
                left++;
                winl--;
            }

            // Checking window length= s1.Length and whether char match or not
            if(winl == s1.Length){
                bool same = false;

                foreach(var kv in s1map){
                    if(s2map.ContainsKey(kv.Key) && s2map[kv.Key] == kv.Value){
                        same=true;
                    }
                    else{same=false;break;}
                }
                if(same){return true;}
            }
            

        }


        return false;
    }
}
