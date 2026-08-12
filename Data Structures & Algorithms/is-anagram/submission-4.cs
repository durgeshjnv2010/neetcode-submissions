public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length)
        {
            return false;
        }
        else
        {
            Dictionary<char, int> map = [];

            char[] sChars = s.ToCharArray();


            for (int i=0;i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    map[s[i]] = map[s[i]] + 1;
                }
                else
                {
                    map.Add(s[i], 1);
                }

                if (map.ContainsKey(t[i]))
                {
                    map[t[i]]--;
                }
                else
                {
                    map[t[i]] = -1;
                }
            }
            foreach(var keyvalue in map)
            {
                map.TryGetValue(keyvalue.Key, out int value);
                if(value != 0)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
