public class Solution {
    public int OrangesRotting(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        Queue<(int row, int col)> queue = new();

        int fresh = 0;
        int minutes =0;
        // Put all rotten fruits in queue
        // and count fresh fruits

        for(int r=0; r<rows;r++){
            for(int c=0; c<cols;c++){
                if(grid[r][c] == 2){
                    queue.Enqueue((r,c));
                }
                else if(grid[r][c] ==1){
                    fresh++;
                }
            }
        }

        int[][] directions = {
            new int[]{-1,0},
            new int[]{1,0},
            new int[]{0, -1},
            new int[]{0,1}
        };

        while(queue.Count > 0 && fresh >0){
            int size = queue.Count;

            // One BFS level = one minute
            for(int i=0; i<size;i++){
                var (row, col) = queue.Dequeue();

                foreach(var direction in directions){
                    int newrow = row + direction[0];
                    int newcol = col + direction[1];

                    // out of bound
                    if(newrow < 0 || newrow >= rows || newcol < 0 || newcol >= cols){
                        continue;
                    }

                    // only fresh can rot
                    if(grid[newrow][newcol] != 1){
                        continue;
                    }

                    //fresh --> rotten
                    grid[newrow][newcol] = 2;
                    fresh--;

                    queue.Enqueue((newrow, newcol));
                }
            }

            minutes++;
        }
        // Fresh fruits still remaining
        if (fresh > 0)
        {
            return -1;
        }

        return minutes;

    }
}
