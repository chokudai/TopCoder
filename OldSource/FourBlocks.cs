using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FourBlocks {
    public int maxScore(string[] grid)
    {
        int len = grid[0].Length;
        int n = grid.Length;
        int loop = 1 << n;
        int i, j, k;
        int[] num = new int[len];
        int[,] dp = new int[len, loop];
        for (i = 0; i < loop; i++)
        {
            for (j = 0; j < len; j++)
            {
                dp[j,i] = -1;
            }
        }
        int now = 0;
        for (i = 0; i < len; i++)
        {
            num[i] = 0;
            for (j = 0; j < n; j++)
            {
                if (grid[j][i] == '1') num[i] += (1 << j);
            }
        }
        for (i = 0; i < n; i++) if (grid[i][0] == '1') {now += (1 << i); }
        dp[0, now] = 0;

        for (i = 0; i < len - 1; i++)
        {
            for (j = 0; j < loop; j++)
            {
                if (dp[i, j] == -1) continue;
                for (k = 0; k < (loop>>1); k++)
                {
                    if ((k & (k << 1)) != 0) continue;
                    if ((j | k) != (j ^ k)) continue;
                    if ((j | (k << 1)) != (j ^ (k << 1))) continue;
                    if ((num[i + 1] | k) != (num[i + 1] ^ k)) continue;
                    if ((num[i + 1] | (k << 1)) != (num[i + 1] ^ (k << 1))) continue;
                    int next = num[i + 1] | k | (k << 1);
                    dp[i + 1, next] = Math.Max(dp[i + 1, next], dp[i, j] + countbit(k));
                }
            }
        }
        int res = 0;
        for (j = 0; j < loop; j++)
        {
            res = Math.Max(res, dp[len - 1, j]);
        }
        return n * len + res * 12;
    }

    public int countbit(int a)
    {
        int i = 0;
        int res = 0;
        while ((a >> i) != 0)
        {
            res += ((a >> i) & 1);
            i++;
        }
        return res;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
