namespace ProblemSolving.Problems.Hashmap;

// https://leetcode.com/problems/valid-sudoku/description/

public static class ValidSudoku
{
    public static bool Solution(char[][] board)
    {
        Dictionary<int, HashSet<char>> Row = new();
        Dictionary<int, HashSet<char>> Column = new();
        Dictionary<int, HashSet<char>> Grid = new();
        
        int i = 0;
        int j = 0;
        for (i = 0; i < board.Length; i++)
        {
            for (j = 0; j < board[0].Length; j++)
            {
                if (board[i][j]=='.')
                    continue;
                
                if (!Row.TryAdd(i,new HashSet<char>{board[i][j]}))
                    if (Row[i].Contains(board[i][j]))
                        return false;
                    else
                        Row[i].Add(board[i][j]);
                if (!Column.TryAdd(j,new HashSet<char>{board[i][j]}))
                    if (Column[j].Contains(board[i][j]))
                        return false;
                    else
                        Column[j].Add(board[i][j]);
                int gridNum = (i/3)*3 + j/3;
                if (!Grid.TryAdd(gridNum,new HashSet<char>{board[i][j]}))
                    if (Grid[gridNum].Contains(board[i][j]))
                        return false;
                    else
                        Grid[gridNum].Add(board[i][j]);
            }


        }

        return true;
    }
}