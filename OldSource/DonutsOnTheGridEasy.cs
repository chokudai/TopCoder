using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DonutsOnTheGridEasy {
    public int calc(string[] firstgrid)
    {
        int i, j, w, h;
        string[] grid = new string[firstgrid.Length + 2];
        grid[0] = new string('.', firstgrid[0].Length + 2);
        grid[firstgrid.Length + 1] = new string('.', firstgrid[0].Length + 2);
        for (i = 0; i < firstgrid.Length; i++) grid[i + 1] = "." + firstgrid[i] + ".";

        int[, ,,] dp = new int[grid.Length, grid[0].Length, grid.Length, grid[0].Length];

        int[,] tate = new int[grid.Length, grid[0].Length];
        int[,] yoko = new int[grid.Length, grid[0].Length];

        for (i = 0; i < grid.Length; i++)
        {
            int now = 0;
            for (j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '0') now++;
                else now = 0;
                yoko[i, j] = now;
            }
        }
        for (j = 0; j < grid[0].Length; j++)
        {
            int now = 0;
            for (i = 0; i < grid.Length; i++)
            {
                if (grid[i][j] == '0') now++;
                else now = 0;
                tate[i, j] = now;
            }
        }
        int res = 0;
        for (w = 2; w < grid.Length-2; w++)
        {
            for (h = 2; h < grid[0].Length-2; h++)
            {
                for (i = 1; i < grid.Length-w-1; i++)
                {
                    for (j = 1; j < grid[0].Length-h-1; j++)
                    {
                        if (tate[i + w, j] > w && tate[i + w, j + h] > w && yoko[i, j + h] > h && yoko[i + w, j + h] > h)
                        {
                            dp[w + 2, h + 2, i - 1, j - 1] = Math.Max(dp[w + 2, h + 2, i - 1, j - 1], dp[w, h, i, j] + 1);
                            res = Math.Max(res,dp[w + 2, h + 2, i - 1, j - 1]);
                        }
                        dp[w + 1, h, i, j] = Math.Max(dp[w + 1, h, i, j], dp[w, h, i, j]);
                        dp[w + 1, h, i - 1, j] = Math.Max(dp[w + 1, h, i - 1, j], dp[w, h, i, j]);
                        dp[w, h + 1, i, j] = Math.Max(dp[w, h + 1, i, j], dp[w, h, i, j]);
                        dp[w, h + 1, i, j - 1] = Math.Max(dp[w, h + 1, i, j - 1], dp[w, h, i, j]);
                        dp[w + 2, h + 2, i - 1, j - 1] = Math.Max(dp[w + 2, h + 2, i - 1, j - 1], dp[w, h, i, j]);
                    }
                }
            }
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
