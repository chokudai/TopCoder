using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AllButOneDivisor {
    public int getMinimum(int[] divisors)
    {
        long res = long.MaxValue;
        int i ,j;
        int len = divisors.Length;
        for (i = 0; i < len; i++)
        {
            long now = 1;
            for (j = 0; j < len; j++)
            {
                if (i != j)
                {
                    now = lcm(now, divisors[j]);
                }
            }
            if (now % divisors[i] != 0)
            {
                res = Math.Min(now, res);
            }
        }
        if (res == long.MaxValue) return -1;
        return (int)res;
    }

    long lcm(long a, long b)
    {
        return a * b / gcd(a, b);
    }

    long gcd(long a, long b)
    {
        if (b == 0) return a;
        else return gcd(b, a % b);
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
