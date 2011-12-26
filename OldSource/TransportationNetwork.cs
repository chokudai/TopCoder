using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TransportationNetwork {

    int[] point;
    
    public double minCost(int[] cityX, int[] cityY, double roadCost, double airportCost)
    {
        int i, j, k;
        int len = cityX.Length;
        double[,] dif = new double[len + 1, len + 1];

        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                dif[i, j] = Math.Sqrt(Math.Max(0, (cityX[i] - cityX[j]) * (cityX[i] - cityX[j]) + (cityY[i] - cityY[j]) * (cityY[i] - cityY[j]))) * roadCost;
            }
        }
        for (i = 0; i < len; i++)
        {
            dif[len, i] = airportCost;
            dif[i, len] = airportCost;
        }

        double res = double.MaxValue;

        point = new int[len];
        for (i = 0; i < point.Length; i++) point[i] = -1;
        double res2 = 0;
        for (k = 0; k < len-1; k++)
        {
            double minnum = double.MaxValue;
            int ii = 0, jj = 1;
            for (i = 0; i < len; i++)
            {
                for (j = i+1; j < len; j++)
                {
                    if (!check(i, j))
                    {
                        if (minnum > dif[i, j])
                        {
                            minnum = dif[i, j];
                            ii = i; jj = j;
                        }
                    }
                }
            }
            res2 += minnum;
            point[jj] = ii;
        }

        res = res2;

        len += 1;
        point = new int[len];
        for (i = 0; i < point.Length; i++) point[i] = -1;
        res2 = 0;
        for (k = 0; k < len - 1; k++)
        {
            double minnum = double.MaxValue;
            int ii = 0, jj = 1;
            for (i = 0; i < len; i++)
            {
                for (j = i + 1; j < len; j++)
                {
                    if (!check(i, j))
                    {
                        if (minnum > dif[i, j])
                        {
                            minnum = dif[i, j];
                            ii = i; jj = j;
                        }
                    }
                }
            }
            res2 += minnum;
            point[jj] = ii;
        }

        res = Math.Min(res2, res);
        return res;

    }

    int root(int a)
    {
        if (point[a] == -1) return a;
        else return root(point[a]);
    }

    bool check(int a, int b)
    {
        return root(a) == root(b);
    }

}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
