public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dictObject = new Dictionary<int, int>();
        foreach (int item in nums)
        {
            if (dictObject.ContainsKey(item))
            {
                dictObject[item]++;
            }
            else{
                dictObject.Add(item, 1);
            }
        }
        var sortedDict = dictObject.OrderByDescending(item => item.Value).ToDictionary(item => item.Key, item => item.Value);
        int[] op = new int[k];

        int counter =0;
        foreach(KeyValuePair<int, int> item in sortedDict)
        {
            if(counter < k)
            {
                op[counter]= item.Key; counter++;
            }
            else
            {
                break;
            }
        }

        return op;
    }
}
