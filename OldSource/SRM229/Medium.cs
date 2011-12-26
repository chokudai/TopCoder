using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BusinessPlan
{
    int[] dp;
    public int howLong(int[] expense, int[] revenue, int[] ptime, int C, int D)
    {
        int len = ptime.Length;
        int i, j, num;
        dp = new int[D + 100];
        if (C >= D) return 0;
        for (i = 0; i <= D; i++) dp[i] = -1;
        dp[C] = 0;
        for (i = C; i < D; i++)
        {
            if (dp[i] != -1)
            {
                for (j = 0; j < len; j++)
                {
                    if (i >= expense[j])
                    {
                        num = Math.Min(D, i - expense[j] + revenue[j]);
                        if (num > i)
                        {
                            if (dp[num] == -1) dp[num] = dp[i] + ptime[j];
                            else dp[num] = Math.Min(dp[i] + ptime[j], dp[num]);
                        }
                    }
                }
            }
        }
        return dp[D];
    }
}
