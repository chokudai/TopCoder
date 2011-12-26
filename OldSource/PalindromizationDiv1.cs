using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PalindromizationDiv1 {

    public int getMinimumCost(string word, string[] operations)
    {
        int alen = 26;
        long MAX = 9999999999999;
        long[,] change = new long[alen, alen];
        long[] add = new long[alen];
        long[] erase = new long[alen];
        int i, j, k;
        for (i = 0; i < alen; i++)
        {
            for (j = 0; j < alen; j++)
            {
                change[i, j] = MAX;
            }
            change[i, i] = 0;
            add[i] = MAX;
            erase[i] = MAX;
        }

        int len = word.Length;
        int[] w = new int[len];
        for (i = 0; i < len; i++)
        {
            w[i] = (int)(word[i] - 'a');
        }

        for (i = 0; i < operations.Length; i++)
        {
            string[] st = operations[i].Split(' ');
            if (st[0] == "add")
            {
                int c1 = (int)(st[1][0] - 'a');
                int cost = int.Parse(st[2]);
                add[c1] = Math.Min(add[c1], cost);
            }
            else if (st[0] == "erase")
            {
                int c1 = (int)(st[1][0] - 'a');
                int cost = int.Parse(st[2]);
                erase[c1] = Math.Min(erase[c1], cost);
            }
            else
            {
                int c1 = (int)(st[1][0] - 'a');
                int c2 = (int)(st[2][0] - 'a');
                int cost = int.Parse(st[3]);
                change[c1, c2] = Math.Min(change[c1, c2], cost);
            }
        }
        for (k = 0; k < alen; k++)
        {
            for (i = 0; i < alen; i++)
            {
                for (j = 0; j < alen; j++)
                {
                    change[i, j] = Math.Min(change[i, j], change[i, k] + change[k, j]);
                }
            }
        }

        for (i = 0; i < alen; i++)
        {
            for (j = 0; j < alen; j++)
            {
                add[i] = Math.Min(add[i], add[j] + change[j, i]);
            }
        }
        for (i = 0; i < alen; i++)
        {
            for (j = 0; j < alen; j++)
            {
                erase[i] = Math.Min(erase[i], erase[j] + change[i, j]);
            }
        }

        long[,] dp = new long[len, len];
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                dp[i, j] = MAX;
            }
        }
        dp[0, len - 1] = 0;
        for (i = 0; i < len; i++)
        {
            for (j = len - 1; j > i; j--)
            {
                for (k = 0; k < alen; k++)
                {
                    dp[i + 1, j] = Math.Min(dp[i + 1, j], dp[i, j] + erase[k] + change[w[i], k]);
                    dp[i, j - 1] = Math.Min(dp[i, j - 1], dp[i, j] + erase[k] + change[w[j], k]);
                    dp[i + 1, j] = Math.Min(dp[i + 1, j], dp[i, j] + add[k] + change[w[i], k]);
                    dp[i, j - 1] = Math.Min(dp[i, j - 1], dp[i, j] + add[k] + change[w[j], k]);
                    dp[i + 1, j - 1] = Math.Min(dp[i + 1, j - 1], dp[i, j] + change[w[i], k] + change[w[j], k]);
                }
            }
        }

        long res = MAX;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (i >= j)
                {
                    res = Math.Min(res, dp[i, j]);
                }
            }
        }
        if (res >= MAX) return -1;
        else return (int)res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
