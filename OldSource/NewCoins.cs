using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class NewCoins {
    public int minCoins(int[] price)
    {
        int[] dp = new int[100003];
        int i, j, k;
        int res = int.MaxValue;
        for (i = 1; i <= 100000; i++) dp[i] = int.MaxValue;
        dp[1] = 0;
        for (k = 0; k < price.Length; k++) dp[1] += price[k];
        for (i = 1; i <= 100000; i++)
        {
            res = Math.Min(dp[i], res);
            for (j = 2; i * j <= 100000; j++)
            {
                int less = 0;
                for (k = 0; k < price.Length; k++)
                {
                    less += price[k] / (i * j) * (j - 1);
                }
                dp[i * j] = Math.Min(dp[i * j], dp[i] - less);
            }
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
