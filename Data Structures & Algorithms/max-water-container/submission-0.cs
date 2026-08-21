public class Solution {
    public int MaxArea(int[] heights) {
        // Area will be (j-i)* Min of Ith el and jth el
        int l=0;
        int r= heights.Length-1;
        int maxArea = 0;
        while(l<r){

            int area = (r-l) * Math.Min(heights[l], heights[r]);
            maxArea = Math.Max(maxArea, area);
            // To increase area we have increase height of l or r whoever is smaller
            if(heights[l] < heights[r]){
                l++;
            }
            else{
                r--;
            }
        }
        return maxArea;
    }
}
