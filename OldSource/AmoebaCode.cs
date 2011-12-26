using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AmoebaCode {
    public int find(string code, int K)
    {
        if (K == 1) return 1;
        int max = (int)(Math.Pow(K, K-1) + 1e-5);
        int[] numar = new int[K];
        int i, j, k;
        numar[0] = 1;
        for (i = 0; i < K-1; i++)
        {
            numar[i + 1] = numar[i] * K;
        }
        int[] dp = new int[max];
        for (i = 0; i < max; i++) dp[i] = K;
        for (i = 0; i < code.Length; i++)
        {
            int[] nextdp = new int[max];
            for (j = 0; j < max; j++) nextdp[j] = 0;
            for (j = 0; j < max; j++)
            {
                int[] memo = new int[K];
                for (k = K - 1; k >= 0; k--)
                {
                    memo[(j / numar[k]) % K] = K - k - 1;
                }
                if (code[i] == '0')
                {
                    for (k = 0; k < K; k++)
                    {
                        int next = (j * K + k) % max;
                        nextdp[next] = Math.Max(nextdp[next], Math.Min(K - memo[k], dp[j]));
                    }
                    
                }
                else
                {
                    for (k = code[i] - '1';;)
                    {
                        int next = (j * K + k) % max;
                        nextdp[next] = Math.Max(nextdp[next], Math.Min(K - memo[k], dp[j]));
                        break;
                    }
                }
            }
            dp = (int[])nextdp.Clone();
        }
        int res = 0;
        for (i = 0; i < max; i++)
        {
            res = Math.Max(dp[i], res);
        }
        return res;
    }
}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
