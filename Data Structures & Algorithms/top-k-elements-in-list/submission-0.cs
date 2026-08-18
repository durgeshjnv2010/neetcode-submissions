public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Map the frequency
        Dictionary<int, int> count = new();
        for(int i =0; i< nums.Length; i++){
            if(!count.ContainsKey(nums[i])){
                count[nums[i]] = 0;
            }
            count[nums[i]]++;
        }
        // Create Frequency Bucket: frq --> [elements from original array]
        //bucket[frequency] = numbers having that frequency
        List<int>[] bucket = new List<int>[nums.Length+1];
        foreach(var kv in count){
            if(bucket[kv.Value] == null){
                bucket[kv.Value] = new List<int>();    // This will make sure, if many element with same frequency
            }
            bucket[kv.Value].Add(kv.Key);
        }
        // Get Top 4: select k element by iterating till k
        // Max frequency can be length of nums, so will iterate till then but in reverse order
        List<int> result = new List<int>();
        for(int frq= nums.Length; frq> 0 && result.Count < k ; frq-- ){
            if(bucket[frq] == null){
                continue;
            }
            else{
                foreach(var num in bucket[frq])
                {
                    result.Add(num);
                    if(result.Count == k){
                        break;
                    }
                }
                
            }
        }
        return result.ToArray();
    }
}
