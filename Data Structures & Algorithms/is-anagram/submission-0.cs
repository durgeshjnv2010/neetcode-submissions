public class Solution {
    public bool IsAnagram(string s, string t) {
        Char[] arr1 = s.ToCharArray();
        Char[] arr2 = t.ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);
        return new String(arr1) == new String(arr2);
    }
}
