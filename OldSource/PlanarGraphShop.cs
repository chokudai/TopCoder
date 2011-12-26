using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PlanarGraphShop {
    public int bestCount(int N)
    {
        int i, j, k;
        int[] dp = new int[N + 1];
        for (i = 0; i < N; i++) dp[i + 1] = 99999;
        dp[0] = 0;
        for (i = 1; i * i * i <= N; i++)
        {
            for (j = 0; j < i * (i + 1) / 2; j++)
            {
                if (i * i * i + j * j > N) break;
                int plus = i * i * i + j * j;
                for (k = 0; k <= N - plus; k++)
                {
                    dp[k + plus] = Math.Min(dp[k + plus], dp[k] + 1);
                }
            }
        }
        return dp[N];
        
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
