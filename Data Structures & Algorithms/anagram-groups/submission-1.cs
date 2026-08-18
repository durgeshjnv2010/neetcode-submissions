public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new ();

        foreach(var word in strs){
            //char[] arr = word.ToCharArray();
            int[] count = new int[26];
            foreach(char c in word){
                count[c-'a']++;
            }
            
            var key = string.Join(',',count);
            if(!map.ContainsKey(key)){
                map[key] = new List<string>();
            }
            map[key].Add(word);



            // Aproach 2

            // Array.Sort(arr);

            // var key = new String(arr);
            // if(!map.ContainsKey(key)){
            //     map[key] = new List<string>();
            // }
            // map[key].Add(word);
        }

        return map.Values.ToList<List<string>>();
    }
}
