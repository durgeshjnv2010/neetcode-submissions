public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        // Check all rows for 1 to 9
        for(int row =0; row< 9; row++){
            HashSet<char> map = new();
            for(int col=0; col<9;col++){
                char value = board[row][col];
                if(value == '.'){
                    continue;
                }
                if(!map.Add(value)){
                    return false;
                }
            }
        }

        // Check all columns
        for(int col =0; col<9;col++){
            HashSet<char> map = new();
            for(int row=0;row<9;row++){
                char value = board[row][col];
                if(value == '.'){
                    continue;
                }
                if(!map.Add(value)){
                    return false;
                }
            }
        }

        // Check all 3X3 boxes for 1 to 9
        for(int boxrow =0; boxrow<9;boxrow +=3){
            for(int boxcol=0;boxcol<9;boxcol +=3){
                HashSet<char> set = new();
                // Check all elements for 1 to 9
                for(int row =boxrow; row< boxrow+3; row++){
                    for(int col=boxcol; col< boxcol+3;col++){
                        char value = board[row][col];
                        if(value == '.'){
                            continue;
                        }
                        if(!set.Add(value)){
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }
}
