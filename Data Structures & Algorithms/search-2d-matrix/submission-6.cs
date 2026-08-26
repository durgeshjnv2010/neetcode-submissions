public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for(int i=0;i<matrix.Length;i++){
            if(target < matrix[i][0]){
                // it means target doesnt exist in any row
                return false;
            }
            // last element se chhota ho target to mil sakta h
            if(target <= matrix[i][matrix[i].Length-1]){
                // har row me binary search karenge
                int left = 0;
                int right = matrix[i].Length-1;
                while(left<=right){
                    int mid = left + (right-left)/2;
                    if(target == matrix[i][mid]){
                        return true;
                    }
                    else if(target < matrix[i][mid]){
                        right = mid-1;
                    }
                    else{
                        left = mid+1;
                    }
                }
                return false;

            }
        }
        return false;
    }
}
