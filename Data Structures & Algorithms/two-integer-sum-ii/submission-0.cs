public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // two pointer left and right
        // if L+R > T => move R to left
        // if L+R <T => move L to right
        // Repeat this till l<r

        int l=0;
        int r= numbers.Length-1;

        while(l<r){
            if(numbers[l]+numbers[r] > target){
                r--;
            }
            else if(numbers[l]+numbers[r] < target){
                l++;
            }
            else if(numbers[l]+numbers[r] == target){
                return [l+1,r+1];
            }
        } 
        return [];
    }
}
