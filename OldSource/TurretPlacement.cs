using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TurretPlacement {
    public long count(int[] x, int[] y)
    {
        int i, j;
        long count = 0;
        for (i = 0; i < x.Length; i++)
        {
            for (j = i + 1; j < y.Length; j++)
            {
                long X = x[i] - x[j];
                long Y = y[i] - y[j];
                long def = (long)Math.Sqrt((X * X + Y * Y) * 4 + 1e-9);
                if (def >= 2) count += (def - 1) * (def) / 2;
            }
        }
        return count;
    }

}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
