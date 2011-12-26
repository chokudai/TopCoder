using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class NumberPyramids {

    long MOD = 1000000009;
    public int count(int baseLength, int top)
    {
        if (baseLength >= 25) return 0;
        top -= 1 << (baseLength - 1);
        if (top < 0) return 0;

        int i,j;
        long[] dp = new long[top + 1];
        long less = 1;
        dp[0] = 1;
        for (i = 0; i < baseLength; i++)
        {
            for (j = 0; j <= top - less; j++)
            {
                dp[j + less] += dp[j];
                dp[j + less] %= MOD;
            }
            less *= baseLength - 1 - i;
            less /= (i + 1);
        }
        return (int)dp[top];
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
