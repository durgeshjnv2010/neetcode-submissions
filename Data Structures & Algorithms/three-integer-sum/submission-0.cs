public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // a+b+c =0
        // b+c = -a
        Array.Sort(nums);
        List<List<int>> resp = new List<List<int>>();
        for(int k=0;k<nums.Length-2;k++){
            // Skip duplicate first elements
            if (k > 0 && nums[k] == nums[k - 1])
                continue;
            // Target is -n now
            int t = -nums[k];
            int i = k+1;
            int j = nums.Length-1;
            while(i < j){
                if(nums[i]+nums[j] > t){
                    j--;
                }
                else if(nums[i]+nums[j] < t){
                    i++;
                }
                else{
                    List<int> temp = new List<int>();
                    temp.Add(nums[k]);
                    temp.Add(nums[i]);
                    temp.Add(nums[j]);
                    i++;
                    j--;
                    resp.Add(temp);
                    while(i<j && nums[i] == nums[i-1]){
                        i++;
                    }
                    while(i<j && nums[j] == nums[j+1]){
                        j--;
                    }
                }
            }            
            
        }
        return resp;
    }
}
