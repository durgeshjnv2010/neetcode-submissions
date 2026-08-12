public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();


        foreach (var item in nums)
        {
            if (dict.ContainsKey(item))
            {
                return true;
            }
            else
            {
                dict.Add(item, 1);
            }
        }
        return false;

    }
}