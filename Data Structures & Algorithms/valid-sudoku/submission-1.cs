public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Check each rows for 1 to 9 elements
        for(int row=0;row<9; row++){
            HashSet<char> set = new();
            for(int col =0; col < 9; col++){
                if(board[row][col]=='.'){
                    continue;
                }
                if(!set.Add(board[row][col])){
                    return false;
                }
            }
        }
        // Check each column for 1 to 9 elements
        for(int col=0;col<9;col++){
            HashSet<char> set = new();
            for(int row=0;row<9;row++){
                
                if(board[row][col] == '.'){
                    continue;
                }
                if(!set.Add(board[row][col])){
                    return false;
                }
            }
        }
        // Check each box for 1 to 9 elements
        for(int boxrow = 0; boxrow< 9; boxrow +=3){
            for(int boxcol =0;boxcol<9; boxcol +=3){
                HashSet<int> set = new();
                for(int row = boxrow; row<boxrow+3; row++){
                    for(int col = boxcol; col< boxcol+3; col++){
                        if(board[row][col] == '.'){
                            continue;
                        }
                        if(!set.Add(board[row][col])){
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }
    
}
