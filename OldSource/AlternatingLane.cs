using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AlternatingLane {

    double getnum(int hia, int lowa, int hib, int lowb)
    {
        int i;
        double res = 0;
        for (i = lowa; i <= hia; i++)
        {
            if (i > hib || i < lowb)
            {
                res += Math.Abs((hib + lowb) / 2.0 - i);
            }
            else
            {
                long difa = hib - i;
                long difb = i - lowb;
                res += (difa * (difa + 1) / 2.0 + difb * (difb + 1) / 2.0) / (hib - lowb + 1);
            }
        }
        return res / (hia - lowa + 1);
    }

    public double expectedBeauty(int[] low, int[] high)
    {
        double res = 0;
        for (int i = 0; i < low.Length - 1; i++) res += getnum(high[i], low[i], high[i + 1], low[i + 1]);
        return res;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
