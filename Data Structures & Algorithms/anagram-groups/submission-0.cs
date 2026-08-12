public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs.Length == 0 || strs == null){return new List<List<string>>{};}
        List<List<string>> output = new ();

        Dictionary<string, List<string>> grp = new ();

        for(int i=0; i< strs.Length; i++){
            Char[] charArr1 = strs[i].ToCharArray();
            Array.Sort(charArr1);
            string sortedItem = new String(charArr1);
            if(!grp.ContainsKey(sortedItem)){
                grp[sortedItem] = new List<string>{strs[i]};
            }
            else{
            grp[sortedItem].Add(strs[i]);
            }
        }
        foreach(KeyValuePair<string, List<string>> item in grp){
            output.Add(item.Value);
        }

        return output;
    }
}
