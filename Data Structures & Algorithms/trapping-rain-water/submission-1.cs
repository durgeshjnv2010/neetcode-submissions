public class Solution {
    public int Trap(int[] height) {
        // At any point how much water can be stored
        // water at any point can be calculated as Min(leftmax, rightmax) - height of that point
        // So, Min(leftmax, rightmax) - height[i]
        // One point: water can be accumulated only if current point is lower than lmax and rmax
        //how to calculate leftmax rightmax
        int len = height.Length;
        int total=0;
        int lmax =0;
        int rmax=0;
        int left = 0;
        int right = len-1;
        while(left<right){
            if(height[left] <= height[right]){
                lmax = Math.Max(lmax, height[left]);
                total += lmax-height[left];
                left++;
            }
            else{
                rmax=Math.Max(rmax, height[right]);
                total+= rmax-height[right];
                right--;
            }
        }
        return total;
    }
}
