using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class YetAnotherORProblem {
    public int countSequences(long[] R)
    {
        int len = R.Length;
        int i, j, k;
        int dplen = 1 << len;
        long[] dp = new long[dplen];
        int[] maxbit = new int[len];
        int max = 0;
        long MOD = 1000000009;
        for (i = 0; i < len; i++)
        {
            for (j = 1; ; j++)
            {
                if ((long)1 << (j - 1) <= R[i])
                {
                    maxbit[i] = j;
                    max = Math.Max(j, max);
                }
                else break;
            }
        }

        dp[0] = 1;
        for (i = 0; i < max; i++)
        {
            long[] nextdp = new long[dplen];
            for (j = 0; j < dplen; j++)
            {
                int nextbit = 0;
                for (k = 0; k < len; k++)
                {
                    if ((j >> k) % 2 == 1 && (R[k] >> i) % 2 == 0) nextbit |= (1 << k);
                }
                nextdp[nextbit] += dp[j];
                nextdp[nextbit] %= MOD;
                for (k = 0; k < len; k++)
                {
                    int nnb = nextbit;
                    if (i >= maxbit[k]) continue;
                    if ((j >> k) % 2 == 1 && i + 1 == maxbit[k]) continue;
                    if ((j >> k) % 2 == 1 || (R[k] >> i) % 2 == 0) nnb |= (1 << k);
                    nextdp[nnb] += dp[j];
                    nextdp[nnb] %= MOD;
                }
            }
            dp = (long[])nextdp.Clone();
        }
        long res = 0;
        for (j = 0; j < dplen; j++)
        {
            res += dp[j];
            res %= MOD;
        }
        return (int)res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
