public class Solution {

    public string Encode(IList<string> strs) {
        string res = string.Empty;
        foreach (var item in strs)
        {
            res = string.Concat(res, item.Length, '#', item);
        }
        return res;
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;
        while (i< s.Length)
        {
            int j = i;
            while (s[j] != '#')
            {
                j++;
            }
            int.TryParse(s.Substring(i, j - i), out int length);
            res.Add(s.Substring(j+1, length));
            i = j+length+1;
        }
        return res;
   }
}
