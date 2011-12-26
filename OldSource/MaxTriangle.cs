using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MaxTriangle {
    public double calculateArea(int A, int B)
    {
        long i, j;
        double res = 0;
        long xa, xb, ya, yb;
        for (i = 0; i * i <= A; i++)
        {
            xa = i;
            ya = (long)Math.Sqrt((double)A + 1e-9 - (double)i * i);
            if (xa * xa + ya * ya != A) continue;
            for (j = 0; j * j <= B; j++)
            {
                xb = j;
                yb = (long)Math.Sqrt((double)B + 1e-9 - (double)j * j);
                if (xb * xb + yb * yb != B) continue;
                res = Math.Max(res, Math.Abs(xa * yb - xb * ya));
                res = Math.Max(res, Math.Abs(xa * (-yb) - xb * ya));
                // (p2.x - p1.x) * (p3.y - p1.y) - (p3.x - p1.x) * (p2.y - p1.y);
            }
        }
        if (res == 0) return -1;
        return res/2;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
