using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MissingParentheses {
    public int countCorrections(string par)
    {
        int count = 0;
        int now = 0;
        foreach (char c in par)
        {
            if (c == '(') now++;
            else now--;
            if (now < 0)
            {
                count += 1;
                now += 1;
            }
        }
        count += Math.Max(now, 0);
        return count;

    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
