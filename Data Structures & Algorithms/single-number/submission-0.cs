public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> map = new();

        foreach(int n in nums){
            if(!map.Contains(n)){
                map.Add(n);
            }
            else{
                map.Remove(n);
            }
        }

        return map.First();
    }
}
