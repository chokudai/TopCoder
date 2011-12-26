using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SquareFreeNumbers {
public int getCount(long min, long max) {
    long i;
    int count = 0;
    long len = max - min + 1;
    bool[] memo = new bool[len];
    for (i = 0; i < len; i++) memo[(int)i] = true;
    for (i = 2;; i++)
    {
        long now = i * i;
        if (now > max) break;
        for (long j = ((min + now - 1) / now) * now; j <= max; j += now)
        {
            memo[(int)(j - min)] = false;
        }
    }
    for (i = 0; i < len; i++) if (memo[(int)i]) count++;
    return count;
}



}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
