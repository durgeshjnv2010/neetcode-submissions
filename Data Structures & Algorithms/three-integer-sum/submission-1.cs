public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // a+b+c = 0
        // Rest Two Sum approach
        // a+b = -c
        // So for each -number will be target and we have to find a and b

        List<List<int>> res = new();
        // WIll sort nums using Array.Sort
        Array.Sort(nums);
        // Since we have to take 3 element so we have to traverse till length-2 for finding 2 element
        for(int i =0; i<nums.Length-2; i++){
            int target = - nums[i];
            int j = i+1;
            int k = nums.Length-1;
            // If the current k value is the same as the previous k value, don't process it.
            // Because the array is sorted, duplicates are next to each other.
            if(i>0 && nums[i] == nums[i-1]){
                continue;
            }

            while(j<k){
                int sum = nums[j] + nums[k];
                if(sum < target){
                    j++;
                }
                else if(sum > target){
                    k--;
                }
                else{
                    List<int> temp = new();
                    temp.Add(nums[i]);
                    temp.Add(nums[j]);
                    temp.Add(nums[k]);
                    res.Add(temp);

                    j++;
                    k--;

                    //Skip duplicate element for j and k 
                    while(j<k && nums[j] == nums[j-1]){
                        j++;
                    }
                    while(j<k && nums[k] == nums[k+1]){
                        k--;
                    }
                    
                }
            }
        }
        return res;
    }
}
