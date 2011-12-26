using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MagicalGirlLevelTwoDivOne {

    long mod = 1000000007;

    long[] pow5, pow4;
    bool[] memo;

    public int theCount(string[] palette, int n, int m)
    {
        bool[,] even = new bool[n, m];
        bool[,] odd = new bool[n, m];
        int i, j;
        int h = palette.Length;
        int w = palette[0].Length;
        int[,] board = new int[h, w];


        long bmul = 1;

        pow4 = new long[5000];
        pow5 = new long[5000];
        pow4[0] = pow5[0] = 1;
        for (i = 1; i < 5000; i++)
        {
            pow4[i] = (pow4[i - 1] * 4) % mod;
            pow5[i] = (pow5[i - 1] * 5) % mod;
        }

        memo = new bool[1 << m];
        for (i = 0; i < (1 << m); i++)
        {
            memo[i] = false;
            for (j = 0; j < m; j++)
            {
                if ((i >> j) % 2 == 1)
                {
                    memo[i] = !memo[i];
                }
            }
        }

        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                if (palette[i][j] != '.')
                {
                    board[i, j] = palette[i][j] - '0';
                    if (board[i, j] % 2 == 0)
                    {
                        even[i % n, j % m] = true;
                    }
                    else
                    {
                        odd[i % n, j % m] = true;
                    }
                    if (even[i % n, j % m] && odd[i % n, j % m]) return 0;
                }
                else board[i, j] = 0;
            }
        }

        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                if (palette[i][j] == '.')
                {
                    if (even[i % n, j % m]) bmul *= 4;
                    if (odd[i % n, j % m]) bmul *= 5;
                    bmul %= mod;
                }
            }
        }

        long[] dp = new long[1 << m];
        dp[0] = 1;
        for (i = 0; i < n; i++)
        {
            List<int> kl = new List<int>();
            for (j = 0; j < (1 << m); j++)
            {
                if (dp[j] != 0) kl.Add(j);
            }
            long[] nextdp = new long[1 << m];
            long[] mul = new long[1 << m];
            for (int ii = 0; ii < (1 << m); ii++)
            {
                mul[ii] = 1;
                for (j = 0; j < m; j++)
                {
                    if (!even[i, j] && !odd[i, j])
                    {
                        int counth = (h - i + n - 1) / n;
                        int countw = (w - j + m - 1) / m;
                        //Console.WriteLine(counth + " " + countw);
                        if ((ii >> j) % 2 == 0)
                        {
                            mul[ii] *= pow4[Math.Max(counth * countw, 0)];
                        }
                        else
                        {
                            mul[ii] *= pow5[Math.Max(counth * countw, 0)];
                        }
                        mul[ii] %= mod;
                    }
                }
            }

            int d = 0;
            int r = 0;

            for (j = 0; j < m; j++)
            {
                if (!even[i, j] && !odd[i, j]) d |= (1 << j);
                if (odd[i, j])
                {
                    r |= (1 << j);
                }
            }
            for (j = d; j >= 0; j -= 1)
            {
                j &= d;
                if (!(memo[r] ^ memo[j])) continue;
                long next = j ^ r;
                foreach (int kk in kl)
                {
                    nextdp[kk ^ next] = (nextdp[kk ^ next] + (dp[kk] * mul[j])) % mod;
                }
            }
            dp = (long[])nextdp.Clone();
        }
        //Console.ReadLine();
        return (int)((dp[(1 << m) - 1] % mod) * bmul % mod);
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
