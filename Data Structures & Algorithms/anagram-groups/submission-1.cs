public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        foreach(string item in strs){
            string sortedItem = new string(item.OrderBy(c => c).ToArray());
            if(dict.ContainsKey(sortedItem)){
                dict[sortedItem].Add(item);
            }
            else{
                dict[sortedItem] = new List<string>{item};
            }
        }

        return dict.Values.ToList();
    }
}
