public class Solution {
    public bool IsAnagram(string s, string t) {
        // First Condition , if strings of diff length then no Anagram
        if(s.Length != t.Length){
            return false;
        }

        int len = s.Length;
        // Will create a freq map and for s will add and for t remove
        // At last if any key have value > 0 then no anagram
        Dictionary<char, int> map = new();
        for (int i =0; i < len; i++){
            if(!map.ContainsKey(s[i])){
                map[s[i]] = 0;
            }
            map[s[i]] ++;
        }
        for (int i =0; i < len; i++){
            if(map.ContainsKey(t[i])){
                map[t[i]] --;
            }
        }

        foreach(var kv in map){
            if(kv.Value > 0){
                return false;
            }
        }
        return true;
    }
}
