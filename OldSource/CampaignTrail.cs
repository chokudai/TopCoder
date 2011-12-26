using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CampaignTrail {
    public double probWin(int[] electors, int[] winCurrent, int[] winIfVisited, int visits)
    {
        double[,] now = new double[2601, 53];
        double[,] next = new double[2601, 53];
        int i, j, k;
        int len = electors.Length;
        int sum = 0;
        for (i = 0; i < len; i++)
        {
            sum += electors[i];
        }
        for (i = 0; i < 2501; i++)
        {
            for (j = 0; j <= visits; j++)
            {
                if (i > sum / 2) now[i, j] = 1;
                else now[i, j] = 0;
                next[i, j] = 0;
            }
        }

        for (k = len - 1; k >= 0; k--)
        {
            for (i = 0; i < 2501; i++)
            {
                for (j = 0; j <= visits; j++)
                {
                    next[i, j] = Math.Max(next[i, j], (now[i + electors[k], j] * winCurrent[k] + now[i, j] * (100 - winCurrent[k])) / 100);
                    next[i, j + 1] = Math.Max(next[i, j + 1], (now[i + electors[k], j] * winIfVisited[k] + now[i, j] * (100 - winIfVisited[k])) / 100);

                }
            }
            for (i = 0; i < 2501; i++)
            {
                for (j = 0; j <= visits; j++)
                {
                    now[i, j] = next[i, j];
                }
            }
        }
        double res = 0;
        for (j = 0; j <= visits; j++)
        {
            res = Math.Max(res, now[0, j]);
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
