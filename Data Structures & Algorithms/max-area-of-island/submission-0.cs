public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int rows=grid.Length;
        int cols=grid[0].Length;
        int maxarea=0;
        for(int r=0;r<rows;r++){
            for(int c=0;c<cols;c++){
                if(grid[r][c] ==1){
                    int area = Dfs(r,c);
                    maxarea = Math.Max(maxarea, area);
                }
            }
        }
        return maxarea;

        int Dfs(int row, int col){

            // Out of bound
            if(row<0 || row>=rows||col <0||col>=cols){
                return 0;
            }

            // Already visited or water
            if(grid[row][col] == 0){
                return 0;
            }

            //mark visited
            grid[row][col] =0;

            return 1+Dfs(row-1,col)+Dfs(row+1,col)+Dfs(row, col-1)+Dfs(row,col+1);
        }
    }
}
