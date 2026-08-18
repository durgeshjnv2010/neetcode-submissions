public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new ();

        foreach(var word in strs){
            char[] arr = word.ToCharArray();
            Array.Sort(arr);

            var key = new String(arr);
            if(!map.ContainsKey(key)){
                map[key] = new List<string>();
            }
            map[key].Add(word);
        }

        return map.Values.ToList<List<string>>();
    }
}
