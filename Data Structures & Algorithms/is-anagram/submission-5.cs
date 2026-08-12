public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char, int> map = [];


        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        for (int i =0; i< sArray.Length; i++){
            if(map.ContainsKey(sArray[i])){
                map[sArray[i]] +=1;
            }
            else{
                map.Add(sArray[i], 1);
            }
        }

        for (int j =0; j < tArray.Length; j++){
            if(map.ContainsKey(tArray[j])){
                map[tArray[j]] -= 1;
            }
            else{

            }
        }

        foreach(var kvPair in map){
            if(kvPair.Value != 0){
                return false;
            }
        }
        return true;
    }
}
