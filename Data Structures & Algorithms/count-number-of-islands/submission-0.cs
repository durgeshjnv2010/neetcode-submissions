public class Solution {
    public int NumIslands(char[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int count=0;
        for(int r=0;r<rows;r++){
            for(int c=0;c<cols;c++){
                // found new island
                if(grid[r][c] == '1'){
                    count++;
                    // Visit entire island
                    Dfs(r,c);
                }
            }
        }
        return count;

        void Dfs(int row, int col){
            // out of bound
            if(row< 0 || row >= rows || col < 0 || col >= cols){
                return;
            }
            // Water or already visite
            if(grid[row][col] =='0'){
                return;
            }

            // Mark visited
            grid[row][col] = '0';

            // Explore four direction
            Dfs(row-1, col); //up
            Dfs(row+1, col); //down
            Dfs(row, col-1); // left
            Dfs(row, col+1); //right
        }
    }
}
