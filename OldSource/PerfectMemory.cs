using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PerfectMemory {


    int p;
    double[,] dp;
    public double getExpectation(int N, int M)
    {
        int i, j;
        p = N * M / 2;
        dp = new double[p + 1, p + 1];
        for (i = 0; i <= p; i++)
        {
            for (j = 0; j <= p; j++)
            {
                dp[i, j] = -1;
            }
        }
        return saiki(0, p);
    }

    //a: find
    //b: not find
    double saiki(int a, int b)
    {
        if (b == 0) return a;
        if (dp[a, b] >= 0) return dp[a, b];
        double res = 0;
        double f = (double)a / (a + b * 2);
        double nf = 1 - f;
        //Console.WriteLine(a + " " + b + " " + f + " " + nf);
        if (a != 0)
        {
            res += f * (1 + saiki(a - 1, b));
        }
        if (b != 0)
        {
            double ok = nf * (double)1 / (a + b * 2 - 1);
            double fa = nf * (double)a / (a + b * 2 - 1);
            double fb = nf * (double)(2 * (b - 1)) / (a + b * 2 - 1);
            res += ok * (1 + saiki(a, b - 1));
            if (a != 0) res += fa * (2 + saiki(a, b - 1));
            if (b != 1) res += fb * (1 + saiki(a + 2, b - 2));
        }
        //Console.WriteLine(a + " " + b + " " + res);
        return dp[a, b] = res;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
