using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheAlmostLuckyNumbersDivOne {
    public long find(long a, long b)
    {
        return getnum(b) - getnum(a - 1);
    }

    long getnum(long a)
    {
        if (a == 0) return 0;
        long[,] dp = new long[2, 3];
        dp[0, 0] = 1;
        long res = 0;
        while (a != 0)
        {
            long[,] nextdp = new long[2, 3];
            int i, j, k;
            long next = a % 10;
            a /= 10;
            for (i = 9; i >= 0; i--)
            {
                for (j = 0; j < 2; j++)
                {
                    for (k = 0; k < 2; k++)
                    {
                        int add = 1;
                        if (i == 4 || i == 7) add = 0;
                        if (next == i)
                        {
                            nextdp[j, k + add] += dp[j, k];
                        }
                        else if (next < i)
                        {
                            nextdp[1, k + add] += dp[j, k];
                        }
                        else
                        {
                            nextdp[0, k + add] += dp[j, k];
                        }
                    }
                }
                if (i == 1)
                {
                    res += nextdp[0, 0] + nextdp[0, 1];
                    if (a != 0) res += nextdp[1, 0] + nextdp[1, 1];
                }
                
            }
            dp = (long[,])nextdp.Clone();
        }
        return res;
    }



}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
