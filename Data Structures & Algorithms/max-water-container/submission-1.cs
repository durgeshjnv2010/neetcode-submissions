public class Solution {
    public int MaxArea(int[] heights) {
        // Area= (r-l)* Min(heights of l, r)
        // To maximize this, we have to increase min height one
        // So if r is less height then r--
        // if l is less height then l++
        int l = 0;
        int r = heights.Length-1;

        int max = 0;

        while(l<r){
            int area = (r-l) * Math.Min(heights[l], heights[r]);
            max = Math.Max(max, area);
            if(heights[l]<heights[r]){
                l++;
            }
            else{
                r--;
            }
        }
        return max;
    }
}
