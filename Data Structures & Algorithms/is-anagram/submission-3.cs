public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length)
        {
            return false;
        }
        else
        {
            Dictionary<char, int> map1 = [];
            Dictionary<char, int> map2 = [];

            char[] sChars = s.ToCharArray();
            char[] tChars = t.ToCharArray();


            foreach(char c in sChars)
            {
                if (map1.ContainsKey(c))
                {
                    map1[c] = map1[c] + 1;
                }
                else
                {
                    map1.Add(c, 1);
                }
            }
            foreach(char c in tChars)
            {
                if (map2.ContainsKey(c))
                {
                    map2[c] = map2[c] + 1;
                }
                else
                {
                    map2.Add(c,1);
                }
            }
            foreach(var keyvalue in map1)
            {
                map2.TryGetValue(keyvalue.Key, out int value);
                if(value != keyvalue.Value)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
