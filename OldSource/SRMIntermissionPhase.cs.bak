using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SRMIntermissionPhase {
    long mod = 1000000007;
    int MAX = 200020;
    public int countWays(int[] points, string[] description)
    {
        long[] dp = new long[MAX];
        long[,] howtoget = new long[8, MAX];
        int i, j, k;

        howtoget[0, 0] = 1;
        for (i = 1; i < 8; i++)
        {
            for (k = 0; k < 3; k++)
            {
                if ((i >> k) % 2 == 0) continue;
                int pre = i - (1 << k);
                long now = 0;
                for (j = 0; j < MAX; j++)
                {
                    howtoget[i, j] = now;
                    now += howtoget[pre, j];
                    if (j >= points[k]) now -= howtoget[pre, j - points[k]];
                    now = (now % mod) + mod;
                    now %= mod;
                }
                break;
            }
        }


        dp[MAX - 1] = 1;
        for (i = 0; i < description.Length; i++)
        {
            int maxpoint = 0;
            int miniscore = 0;
            int now = 0;
            for (j = 0; j < 3; j++)
            {
                if (description[i][j] == 'Y')
                {
                    maxpoint += points[j];
                    miniscore += 1;
                    now += (1 << j);
                }
            }
            long[] nextdp = new long[MAX];
            long now2 = 0;
            for (j = MAX - 1; j >= 0; j--)
            {
                if (j <= maxpoint && j >= miniscore)
                {
                    nextdp[j] = (now2 * howtoget[now, j]) % mod;
                }
                now2 += dp[j];
                now2 %= mod;
            }
            dp = (long[])nextdp.Clone();
        }
        long ret = 0;
        foreach (long a in dp)
        {
            ret += a;
            ret %= mod;
        }
        return (int)ret;

    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
