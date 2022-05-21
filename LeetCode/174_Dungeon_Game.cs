using System;

namespace LeetCode_174
{
    class Solution
    {
        public int CalculateMinimumHP(int[][] dungeon)
        {
            int n = dungeon.Length - 1;
            int m = dungeon[0].Length - 1;

            dungeon[n][m] = Math.Min(0, dungeon[n][m]);

            // Rightmost column
            for (int i = n - 1; i >= 0; i--)
                dungeon[i][m] = Math.Min(0, dungeon[i][m] + dungeon[i + 1][m]);

            // Bottom row
            for (int j = m - 1; j >= 0; j--)
                dungeon[n][j] = Math.Min(0, dungeon[n][j] + dungeon[n][j + 1]);

            // Remaining top-left rectangle
            for (int i = n - 1; i >= 0; i--)
                for (int j = m - 1; j >= 0; j--)
                {
                    dungeon[i][j] = Math.Max(dungeon[i + 1][j], dungeon[i][j + 1]) + dungeon[i][j];
                    dungeon[i][j] = Math.Min(0, dungeon[i][j]);
                }

            return 1 - Math.Min(0, dungeon[0][0]);
        }
    }
}