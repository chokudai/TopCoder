using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DiceRotation {
    public int theCount(int goalx, int goaly)
    {
        if (goalx < goaly) return theCount(goaly, goalx);
        int res = 0;
        if (goaly != 1 && goalx != 1) res += 2;
        if (goaly == 4)
        {
            res += goalx + 1;
        }
        if (goalx == 4)
        {
            res += goaly + 1;
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
