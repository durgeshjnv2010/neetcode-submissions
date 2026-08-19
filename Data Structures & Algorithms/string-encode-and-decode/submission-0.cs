public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder res = new();
        foreach(string s in strs){
            res.Append(s.Length);
            res.Append('#');
            res.Append(s);
        }
        return res.ToString();
    }

    public List<string> Decode(string s) {
        List<string> res = new();
        
        int i =0;
        while(i< s.Length){
            ///Using J iterator get length
            int j = i;
            while(s[j] != '#'){
                j++;
            }
            int len = int.Parse(s.Substring(i, (j-i)));
            string tmp = s.Substring(j+1, len);
            res.Add(tmp);
            i = j+1+len;
        }
        return res;
   }
}
