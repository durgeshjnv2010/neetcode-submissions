public class Solution {
    public bool Exist(char[][] board, string word) {
        int rows = board.Length;
        int cols = board[0].Length;

        for(int r=0; r< rows; r++){
            for(int c=0; c<cols;c++){
                if(Backtrack(r,c,0)) //0 is which char we are looking for
                {
                    return true; 
                }
            }
        }

        return false;

        bool Backtrack(int row, int col, int index){
            // Base case
            if(index == word.Length){
                return true;
            }

            // Boundry case
            if(row<0 || col< 0 || row >= rows || col >= cols){
                return false;
            }
            // Wrong character / already visited
            if(board[row][col] != word[index]){
                return false;
            }

            //Choose
            char original = board[row][col];
            board[row][col] = '#';

            // Explore 4 directions
            bool found = Backtrack(row-1, col, index+1) ||
                        Backtrack(row+1, col, index+1) ||
                        Backtrack(row, col-1, index+1) ||
                        Backtrack(row, col+1, index+1);

            // remove
            board[row][col] = original;
            return found;
        }
    }
}
