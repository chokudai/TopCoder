using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class InfiniteSequence2
{
    long[] dp = new long[1000001];
    public long calc(long n, int p, int q, int x, int y)
    {
        if (n <= 0) return 1;
        if (n <= 1000000 && dp[n] != 0) return dp[n];
        long res = calc(n / p - x, p, q, x, y) + calc(n / q - y, p, q, x, y);
        if (n <= 1000000) dp[n] = res;
        return res;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
