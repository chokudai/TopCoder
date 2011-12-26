using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SameDigits {
    public int howMany(int n, int k)
    {
        long mod = 44444444;
        long[,] dp = new long[n + 1, 2]; //Œ»İ‚ÌŒ…”A‚‹Œ…•À‚×‚½‚©‚Ìƒtƒ‰ƒO
        dp[0, 0] = 1; //0
        int i, j, l;
        for (i = 0; i < n; i++)
        {
            for (j = 1; i + j <= n && j <= k; j++)
            {
                for (l = 0; l < 2; l++)
                {
                    if (j == k)
                    {
                        dp[i + j, 1] += dp[i, l] * 9;
                        dp[i + j, 1] %= mod;
                    }
                    else
                    {
                        dp[i + j, l] += dp[i, l] * 9;
                        dp[i + j, l] %= mod;
                    }
                }
            }
        }
        long res = 0;
        for (i = 0; i <= n; i++)
        {
            res += dp[i, 1];
            res %= mod;
        }
        return (int)res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
