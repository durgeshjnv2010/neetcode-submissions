public class Solution {
    public int MaxProfit(int[] prices) {
        int profit=0;
        int minprice=prices[0];
        for(int i=1;i< prices.Length;i++){
            profit= Math.Max(profit, prices[i]-minprice);
            minprice= Math.Min(minprice, prices[i]);
        }

        return profit;
    }
}
