public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int bp = prices[0];

        for(int i=1; i< prices.Length;i++){
           bp = Math.Min(bp, prices[i]);
           maxProfit = Math.Max(maxProfit, prices[i]-bp);
        }
        return maxProfit;
    }
}
