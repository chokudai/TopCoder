using System;
using System.Collections.Generic;

public class HandsShaking
{
    long[] dp;

    public long countPerfect(int n)
    {
        dp = new long[100];
        return dfs(n);
    }

    long dfs(int n)
    {
        if (dp[n] != 0) return dp[n];
        if (n == 0) return 1;
        long res = 0;
        int i;
        for (i = 0; i <= n - 2; i += 2)
        {
            res += dfs(i) * dfs(n - 2 - i);
        }
        return dp[n] = res;
    }

}
