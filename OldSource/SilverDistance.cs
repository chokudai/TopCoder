using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SilverDistance {
    public int minSteps(int sx, int sy, int gx, int gy)
    {
        if (Math.Abs(sx - gx) % 2 == Math.Abs(sy - gy) % 2) return Math.Max(Math.Abs(sx - gx), Math.Abs(sy - gy));
        return Math.Max(Math.Abs(sx - gx), Math.Abs((sy+1) - gy)) + 1;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
