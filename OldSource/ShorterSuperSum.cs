using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ShorterSuperSum {
    public int calculate(int k, int n)
    {
        if (k == 0) return n;
        int i, res = 0;
        for (i = 1; i <= n; i++) res += calculate(k - 1, i);
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
