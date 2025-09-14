namespace DSA.GetHandsDirty.GraphProblems;

/// <summary>
/// LeetCode 200
/// https://leetcode.com/problems/number-of-islands/description/
/// </summary>
public class NumberOfIslands
{
    public int NumIslands(char[][] grid)
    {
        if (grid is null || grid.Length == 0)
            return 0;
        
        int rows = grid.Length;
        int cols = grid[0].Length;
        int count = 0;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == '1')
                {
                    count++; // Soma uma ilha encontrada
                    Dfs(grid, r, c);
                }
            }
        }

        return count;
        
        void Dfs(char[][] grid, int r, int c)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            // Verifica se a coordenada está fora da matriz
            if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] != '1')
                return;

            grid[r][c] = '0'; // Afunda a ilha para não contabilizar novamente

            // Verifica cada vizinho na vertical e horizontal (up, down, left, right)
            Dfs(grid, r + 1, c);
            Dfs(grid, r - 1, c);
            Dfs(grid, r, c + 1);
            Dfs(grid, r, c - 1);
        }
    }
}