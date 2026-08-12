public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        List<int> res = new List<int>();
        int product = 1;


        for(int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if(i != j)
                {
                    product *= nums[j];
                }
            }
            res.Add(product);
            product = 1;
        }


        return res.ToArray();
    }
}
