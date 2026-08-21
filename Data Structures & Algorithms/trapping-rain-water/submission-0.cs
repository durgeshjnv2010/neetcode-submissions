public class Solution {
    public int Trap(int[] height) {
        // At any point how much water can be stored
        // water at any point can be calculated as Min(leftmax, rightmax) - height of that point
        // So, Min(leftmax, rightmax) - height[i]
        // One point: water can be accumulated only if current point is lower than lmax and rmax
        //how to calculate leftmax rightmax
        int len = height.Length;
        int total=0;
        int[] lmax= new int[height.Length];
        int[] rmax= new int[height.Length];
        lmax[0]=height[0];
        for(int k =1; k<len; k++){
            lmax[k] = Math.Max(height[k],lmax[k-1]); 
        }
        rmax[len-1] = height[len-1];
        for(int k = len-2; k>=0;k--){
            rmax[k] = Math.Max(height[k], rmax[k+1]);
        }
        for(int i=1; i<len-1;i++){
            int t=  Math.Min(lmax[i], rmax[i])-height[i];
            total +=t;
        }
        return total;
    }
}
