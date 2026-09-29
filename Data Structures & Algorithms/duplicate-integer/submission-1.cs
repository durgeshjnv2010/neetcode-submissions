public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> map =new();

        foreach(int n in nums){
            if(!map.Contains(n)){
                map.Add(n);
                
            }
            else{
                return true;
            }
        }
        return false;

    }
}