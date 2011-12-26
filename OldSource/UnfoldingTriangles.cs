using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class UnfoldingTriangles {
    int x, y;
    
    public int solve(string[] grid, int unfoldLimit)
    {
        x = grid[0].Length;
        y = grid.Length;
        int i, j,k,l;
        int res = 0;
        for (j = 0; j < y; j++)
        {
            for (i = 0; i < x; i++)
            {
                int now = 0;
                for (k = 0; ; k++)
                {
                    if (!ok(i - k, j + k)) break;
                    if (ok(i + 1, j + k) && grid[j + k][i + 1] == '#') break;
                    if (grid[j + k][i - k] != '/') break;
                    for (l = 0; l < k; l++)
                    {
                        if (grid[j + k][i - l] == '.') { now = int.MaxValue; break; }
                        else if (grid[j + k][i - l] == '/') { now++; }
                    }
                    if (now <= unfoldLimit)
                    {
                        bool flag = true;
                        if (ok(0 , j + k + 1))
                        {
                            for (l = 0; l <= k; l++)
                            {
                                if (grid[j + k + 1][i - l] == '#') flag = false;
                            }
                        }
                        if (flag) res = Math.Max(res, k + 1);
                    }
                    else break;
                }
            }
        }

        if (res == 0) return -1;
        else return res * (res + 1) / 2;
    }

    bool ok(int i, int j)
    {
        return i >= 0 && j >= 0 && i < x && j < y;
    }



}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
