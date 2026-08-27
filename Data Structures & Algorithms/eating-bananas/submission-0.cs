public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        // min speed =1;
        // max speed = Max(piles)
        int left = 1;
        int right = piles.Max();

        while(left <= right){
            int mid = left + (right-left)/2;  // Speed of eating banana
            long timetoeat = 0;
            foreach(int pile in piles){
                // int t = (int)Math.Ceil((double)pile/mid);
                int t = (pile + mid - 1) / mid;
                timetoeat +=t;
            }
            if(timetoeat<=h ){
                right = mid-1;
            }
            else{
                left = mid+1;
            }
        }
        return left;
    }
}
