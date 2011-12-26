using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class LuckyRemainder {
    public int getLuckyRemainder(string X)
    {
        int i;
        int res = 0;
        foreach (char a in X) { res += (int)(a - '0'); res %= 9; }
        for (i = 1; i < X.Length; i++)
        {
            res *= 2;
            res %= 9;
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
