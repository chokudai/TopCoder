using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GameOnAGraph {

    int len;
    long mod = 1000000007;

    public int[] getMarks(string[] adj, string colors, string marks, int N)
    {
        len = colors.Length;
        int i, j;
        long[,] wmatrix = new long[len, len];
        long[,] bmatrix = new long[len, len];
        for (i = 0; i < len; i++)
        {
            if (colors[i] == 'W')
            {
                for (j = 0; j < len; j++)
                {
                    if (adj[i][j] == '1' && colors[j] != colors[i])
                    {
                        bmatrix[i, j] = 1;
                    }
                }
                wmatrix[i, i] = 1;
            }
            else
            {
                for (j = 0; j < len; j++)
                {
                    if (adj[i][j] == '1' && colors[j] != colors[i])
                    {
                        wmatrix[i, j] = 1;
                    }
                }
                bmatrix[i, i] = 1;
            }
        }
        long[,] mark = new long[len, 1];
        for (i = 0; i < len; i++) mark[i, 0] = marks[i] - '0';
        mark = matmul(matpow(matmul(bmatrix, wmatrix), N / 2), mark);
        if (N % 2 == 1) mark = matmul(wmatrix, mark);
        int[] res = new int[len];
        for (i = 0; i < len; i++) res[i] = (int)(mark[i, 0] % mod);
        return res;
    }

    long[,] matpow(long[,] m, long a)
    {
        if (a == 0)
        {
            long[,] res = new long[len, len];
            int i;
            for (i = 0; i < len; i++) res[i, i] = 1;
            return res;
        }
        else if (a % 2 == 0)
        {
            long[,] res = matpow(m, a / 2);
            return matmul(res, res);
        }
        else
        {
            return matmul(m, matpow(m, a - 1));
        }
    }

    long[,] matmul(long[,] ma, long[,] mb)
    {
        int i, j, k;
        int len1 = ma.GetLength(0);
        int len2 = mb.GetLength(1);
        int len3 = ma.GetLength(1);
        long[,] res = new long[len1, len2];
        for (i = 0; i < len1; i++)
        {
            for (j = 0; j < len2; j++)
            {
                for (k = 0; k < len3; k++)
                {
                    res[i, j] += ma[i, k] * mb[k, j] % mod;
                }
                res[i, j] %= mod;
            }
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
