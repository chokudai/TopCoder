using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class StrongPrimePower {
    public int[] baseAndExponent(string n)
    {
        long m = long.Parse(n);
        int i,j;
        double EPS = 1e-6;
        for (i = 2; ; i++)
        {
            double nextd = Math.Pow(m, 1.0 / i);
            long next = (long)(nextd + EPS);
            if (next < 2) return new int[0];
            long res = 1;
            for (j = 0; j < i; j++) res *= next;
            if (res == m && isPrime(next)) return new int[] { (int)next, i };
        }
    }

    bool isPrime(long a)
    {
        if (a < 2) return false;
        long i;
        for (i = 2; i * i <= a; i++)
        {
            if (a % i == 0) return false;
        }
        return true;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
