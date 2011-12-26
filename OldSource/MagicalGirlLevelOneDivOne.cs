using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MagicalGirlLevelOneDivOne {
    public string isReachable(int[] jumpTypes, int x, int y)
    {
        if (x == 0 && y == 0) return "YES";
        if (jumpTypes.Length == 0) return "NO";
        if (x % 2 == 0 && y % 2 == 0) return "YES";
        foreach (int a in jumpTypes) if (a % 2 == 0) return "YES";
        if (x % 2 != 0 && y % 2 != 0) return "YES";
        return "NO";
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
