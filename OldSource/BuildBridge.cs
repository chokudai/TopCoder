using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BuildBridge {
    public int howManyCards(int D, int L)
    {
        double res = 0;
        double eps = 1e-9;
        for (int i = 1; ; i++)
        {
            res += (double)L / i / 2;
            if (res + eps > D) return i;
        }
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
