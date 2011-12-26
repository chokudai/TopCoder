using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheNewHouseDivOne {
    public double distance(int[] x, int[] y, int k)
    {
        int len = x.Length;
        int i, j, l;
        double best = double.MaxValue;
        for (i = -100; i <= 100; i++)
        {
            double dx = i / 2.0;
            for (j = -100; j <= 100; j++)
            {
                double dy = j / 2.0;
                double[] ar = new double[len];
                for (l = 0; l < len; l++)
                {
                    ar[l] = Math.Abs(x[l] - dx) + Math.Abs(y[l] - dy);
                }
                Array.Sort(ar);
                best = Math.Min(best, ar[k - 1]);
            }
        }
        return best;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
