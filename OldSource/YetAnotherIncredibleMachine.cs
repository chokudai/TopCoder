using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class YetAnotherIncredibleMachine {
    long mod = 1000000009;

    public int countWays(int[] platformMount, int[] platformLength, int[] balls)
    {
        long res = 1;
        int i, j;
        int len = platformLength.Length;
        int blen = balls.Length;
        for (i = 0; i < len; i++)
        {
            int left = platformLength[i];
            int right = platformLength[i];
            for (j = 0; j < blen; j++)
            {
                if (balls[j] <= platformMount[i])
                {
                    left = Math.Min(left, platformMount[i] - balls[j] - 1);
                }
                if (balls[j] >= platformMount[i])
                {
                    right = Math.Min(right, balls[j] - platformMount[i] - 1);
                }
            }
            int mul = Math.Max(0, left + right - platformLength[i] + 1);
            res *= mul;
            res %= mod;
        }
        return (int)res;
    }



}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
