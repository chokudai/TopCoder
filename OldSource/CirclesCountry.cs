using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CirclesCountry {
    public int leastBorders(int[] X, int[] Y, int[] R, int x1, int y1, int x2, int y2)
    {
        int i;
        int count = 0;
        for (i = 0; i < X.Length; i++)
        {
            if (canlen(X[i], Y[i], x1, y1, R[i]) ^ canlen(X[i], Y[i], x2, y2, R[i])) count++;
        }
        return count;
    }

    bool canlen(int x1, int y1, int x2, int y2, int r)
    {
        return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) <= r*r;
    }



}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
