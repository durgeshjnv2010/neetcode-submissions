public class Solution {
    public bool IsAnagram(string s, string t) {
        // First Condition , if strings of diff length then no Anagram
        if(s.Length != t.Length){
            return false;
        }

        int len = s.Length;
        // Since all chars are lowercase so will create int [] of fixed size 26
        // Will increment count at index ['ith char'- 'a'] for s string
        // Will decrement count at index ['ith char'- 'a'] for t string
        // Check in array, if any value is != 0 then no anagram else anagram
        int[] count = new int[26];
        for(int i=0; i< len; i++){
            count[s[i]-'a']++;
            count[t[i]-'a']--;
        }
        for(int j=0; j< 26; j++){
            if(count[j] != 0){
                return false;
            }
        }
        return true;
    }
}
