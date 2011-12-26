using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BagsOfGold
{
    public int netGain(int[] bags)
    {
        int len = bags.Length;
        int[,] dp = new int[len, len];
        int i, j, k;
        for (k = 0; k < len; k++)
        {
            for (i = 0; i < len; i++)
            {
                j = i + k;
                if (j >= len) continue;
                if (k == 0) { dp[i, j] = bags[i]; continue; }
                int now = bags[i] - dp[i + 1, j];
                now = Math.Max(now, bags[j] - dp[i, j - 1]);
                dp[i, j] = now;
            }
        }
        return dp[0, len - 1];
    }
}
