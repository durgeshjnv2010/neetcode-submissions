public class Solution {
    public bool IsValidSudoku(char[][] board) {    
        Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> squares = new Dictionary<int, HashSet<char>>();

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                var squareKey = (i/3)*3 + j/3;
                char cellValue = board[i][j];
                if (cellValue == '.')
                {
                    continue;
                }
                if (
                    rows.TryGetValue(i, out var rowSet) && rowSet.Contains(cellValue) ||
                    cols.TryGetValue(j, out var colSet) && colSet.Contains(cellValue) ||
                    squares.TryGetValue(squareKey, out var squaresSet) && squaresSet.Contains(cellValue)
                    )
                {
                    return false;
                }
                rows.TryAdd(i, new HashSet<char>());
                cols.TryAdd(j, new HashSet<char>());
                squares.TryAdd(squareKey, new HashSet<char>());


                rows[i].Add(cellValue);
                cols[j].Add(cellValue);
                squares[squareKey].Add(cellValue);
                
            }
        }
        return true;
    }
}
