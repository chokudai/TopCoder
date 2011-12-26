using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class NumbersAndMatches {

    string[] stdata = new string[5];
    int[] pointx = { 1, 0, 2, 1, 0, 2, 1 };
    int[] pointy = { 0, 1, 1, 2, 3, 3, 4 };

    int[,] addline;
    int[,] decline;

    public long differentNumbers(long N, int K)
    {
        stdata[0] = "***   * *** *** * * *** *** *** *** *** ";
        stdata[1] = "* *   *   *   * * * *   *     * * * * * ";
        stdata[2] = "* *   * *** *** *** *** ***   * *** *** ";
        stdata[3] = "* *   * *     *   *   * * *   * * *   * ";
        stdata[4] = "*** *** *** ***   * *** ***   * *** *** ";
        int i, j,k;
        addline = new int[10, 10];
        decline = new int[10, 10];

        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 10; j++)
            {
                int plus = 0;
                int minus = 0;

                for (k = 0; k < 7; k++)
                {
                    if (stdata[pointy[k]][pointx[k] + 4 * i] != stdata[pointy[k]][pointx[k] + 4 * j])
                    {
                        if(stdata[pointy[k]][pointx[k] + 4 * i] == ' ') plus++;
                        else minus++;
                    }
                }
                addline[i, j] = plus;
                decline[i, j] = minus;
                //Console.Write(plus + " ");
            }
            //Console.WriteLine();
        }

        long[,] dp = new long[K + 1, K + 1];
        dp[0, 0] = 1;

        long a = 1;
        for (a = 1; a <= N; a *= 10)
        {
            long now = (N / a) % 10;
            long[,] nextdp = new long[K + 1, K + 1];
            for (k = 0; k < 10; k++)
            {
                int ad = addline[now, k];
                int de = decline[now, k];
                for (i = 0; i <= K - ad; i++)
                {
                    for (j = 0; j <= K - de; j++)
                    {
                        nextdp[i + ad, j + de] += dp[i, j];
                    }
                }
            }
            dp = (long[,])nextdp.Clone();
        }

        long res = 0;
        for (i = 0; i <= K; i++)
        {
            res += dp[i, i];
        }

        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
