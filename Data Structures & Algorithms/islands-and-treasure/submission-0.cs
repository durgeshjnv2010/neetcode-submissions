public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        Queue<(int row, int col)> queue = new();

        for(int r=0; r<rows;r++){
            for(int c=0; c<cols;c++){
                if(grid[r][c] == 0){
                    queue.Enqueue((r,c));
                }
            }
        }

        int[][] directions = {
            new int[]{-1,0}, //up
            new int[]{1,0}, //down
            new int[]{0,-1}, //left
            new int[]{0,1} //right
        };

        while(queue.Count >0){
            var (row, col) = queue.Dequeue();

            foreach(var direction in directions){
                int newrow = row + direction[0];
                int newcol = col + direction[1];


                // out of bound
                if(newrow <0 || newrow >= rows || newcol <0 || newcol >= cols)
                {
                    continue;
                }

                // water
                if(grid[newrow][newcol] == -1){
                    continue;
                }

                //already visited
                if(grid[newrow][newcol] != int.MaxValue){
                    continue;
                }

                //distance = currrent dist + 1
                grid[newrow][newcol] = grid[row][col] +1;
                queue.Enqueue((newrow,newcol));
            }
        }
    }
}
