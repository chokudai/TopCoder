using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DropCoins {

    int[,] sum;
    int h, w;
    public int getMinimum(string[] board, int K)
    {
        int i, j, k, l;
        sum = new int[100, 100];
        h = board.Length;
        w = board[0].Length;
        for (i = 0; i < board.Length; i++)
        {
            for (j = 0; j < board[0].Length; j++)
            {
                sum[i + 1, j + 1] = sum[i + 1, j] + sum[i, j + 1] - sum[i, j];
                if (board[i][j] == 'o') sum[i + 1, j + 1]++;
            }
        }
        int best = 99999;
        for (i = 0; i < h; i++)
        {
            for (j = 0; j < h; j++)
            {
                for (k = 0; k < w; k++)
                {
                    for (l = 0; l < w; l++)
                    {
                        if (getnum(i, j, k, l) == K)
                        {
                            best = Math.Min(best, getres(i, j, k, l));
                        }
                    }
                }
            }
        }
        if (best == 99999) return -1;
        return best;
    }

    int getnum(int a, int b, int c, int d)
    {
        int ymin = a;
        int ymax = h - b;
        int xmin = c;
        int xmax = w - d;
        if (ymin >= ymax) return -1;
        if (xmin >= xmax) return -1;
        return sum[ymax, xmax] + sum[ymin, xmin] - sum[ymin, xmax] - sum[ymax, xmin];
    }

    int getres(int a, int b, int c, int d)
    {
        int ret = 0;
        if (a != 0 && b != 0)
        {
            ret += a + b + Math.Min(a, b);
        }
        else
        {
            ret += a + b;
        }
        if (c != 0 && d != 0)
        {
            ret += c + d + Math.Min(c, d);
        }
        else ret += c + d;
        return ret;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
