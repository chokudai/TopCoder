using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CubeAnts {
    public int getMinimumSteps(int[] pos)
    {
        int res = 0;
        foreach (int a in pos)
        {
            if (a == 6) res = 3;
            else if (a == 2 || a == 5 || a == 7) res = Math.Max(2, res);
            else if (a != 0) res = Math.Max(1, res);
        }
        return res;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
