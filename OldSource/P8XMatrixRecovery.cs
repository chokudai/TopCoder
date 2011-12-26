using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class P8XMatrixRecovery {

    int[,] r1;
    int[,] r2;
    int h, w;
    public string[] solve(string[] rows, string[] columns)
    {
        h = rows.Length;
        w = rows[0].Length;
        int i, j, k;
        r1 = new int[w, h];
        r2 = new int[w, h];

        for (i = 0; i < w; i++)
        {
            for (j = 0; j < h; j++)
            {
                r1[i, j] = ctoi(rows[j][i]);
            }
        }
        for (i = 0; i < w; i++)
        {
            for (j = 0; j < h; j++)
            {
                r2[i, j] = ctoi(columns[i][j]);
            }
        }
        int[,] memo = new int[w, w];
        for (i = 0; i < w; i++)
        {
            for (j = 0; j < w; j++)
            {
                memo[i, j] = match(i, j);
            }
        }
        for (j = 0; j < h; j++)
        {
            for (i = 0; i < w; i++)
            {
                if (r1[i, j] == 2)
                {
                    r1[i, j] = 0;
                    for (k = 0; k < w; k++)
                    {
                        memo[i, k] = match(i, k);
                    }
                    if (hungarian(memo) == w) continue;
                    r1[i, j] = 1;
                    for (k = 0; k < w; k++)
                    {
                        memo[i, k] = match(i, k);
                    }
                }
            }
        }

        string[] ret = new string[h];
        for (i = 0; i < h; i++)
        {
            ret[i] = "";
            for (j = 0; j < w; j++)
            {
                ret[i] += (char)('0' + r1[j, i]);
            }
        }

        return ret;
    }

    int ctoi(char c)
    {
        if (c == '0') return 0;
        if (c == '1') return 1;
        return 2;
    }

    int match(int a, int b)
    {
        for (int i = 0; i < h; i++)
        {
            if (r1[a, i] != r2[b, i] && r1[a, i] != 2 && r2[b, i] != 2)
            {
                return 0;
            }
        }
        return 1;
    }


    long hungarian(int[,] a)
    {
        int n = a.GetLength(0);
        long p, q;
        long[] fx = new long[n];
        long[] fy = new long[n];
        long inf = (long)1e16;
        long i, j, k;
        for (i = 0; i < n; i++) fx[i] = inf;
        for (i = 0; i < n; i++) fy[i] = inf;
        long[] x = new long[n];
        long[] y = new long[n];
        for (i = 0; i < n; i++) x[i] = y[i] = -1;

        for (i = 0; i < n; ++i)
            for (j = 0; j < n; ++j)
                fx[i] = Math.Max(fx[i], a[i, j]);
        for (i = 0; i < n; )
        {
            long[] t = new long[n];
            long[] s = new long[n + 1];
            for (j = 0; j < n; j++) t[j] = -1;
            for (j = 0; j <= n; j++) s[j] = i;
            for (p = q = 0; p <= q && x[i] < 0; ++p)
                for (k = s[p], j = 0; j < n && x[i] < 0; ++j)
                    if (fx[k] + fy[j] == a[k, j] && t[j] < 0)
                    {
                        s[++q] = y[j];
                        t[j] = k;
                        if (s[q] < 0)
                            for (p = j; p >= 0; j = p)
                            {
                                y[j] = k = t[j];
                                p = x[k];
                                x[k] = j;
                            }
                    }
            if (x[i] < 0)
            {
                long d = inf;
                for (k = 0; k <= q; ++k)
                    for (j = 0; j < n; ++j)
                        if (t[j] < 0) d = Math.Min(d, fx[s[k]] + fy[j] - a[s[k], j]);
                for (j = 0; j < n; ++j)
                {
                    if (t[j] >= 0) fy[j] += d;
                }
                for (k = 0; k <= q; ++k) fx[s[k]] -= d;
            }
            else ++i;
        }
        long ret = 0;
        for (i = 0; i < n; ++i) ret += a[i, x[i]];
        return ret;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
