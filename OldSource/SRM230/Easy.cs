using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SortEstimate
{
    int T;
    public double howMany(int c, int time)
    {
        int i;
        T = time;
        double min = 1e-10;
        double max = int.MaxValue;
        for (i = 0; i < 1000000; i++)
        {
            double ave = (min + max) / 2;
            if (check(c, min) > check(c, max))
            {
                min = ave;
            }
            else max = ave;
        }
        return min;
    }

    double check(int c, double n)
    {
        return Math.Abs(Math.Log(n, 2) * c * n - T);
    }
}
