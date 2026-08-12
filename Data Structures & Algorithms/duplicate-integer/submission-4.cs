public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        foreach(int item in nums)
        {
            if(dic.ContainsKey(item)){
                return true;
            }else{
                dic.Add(item,1);
            }
            
        }
        return false;
    }
}