using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DivideAndShift {
    public int getLeast(int N, int M)
    {
        int i;
        int res = 99999999;
        for (i = 1; i * i <= N; i++)
        {
            if (N % i != 0) continue;
            int a = i;
            int b = N / i;
            res = Math.Min(res, check(a, M) + getdiv(b));
            res = Math.Min(res, check(b, M) + getdiv(a));
        }
        return res;
    }

    int check(int a, int b)
    {
        b = b % a;
        if (b == 0) b = a;
        return Math.Min(b - 1, a + 1 - b);
    }

    int getdiv(int a)
    {
        int i;
        int count = 0;
        for (i = 2; i * i <= a; i++)
        {
            while (a % i == 0)
            {
                a /= i;
                count++;
            }
        }
        if (a != 1) count++;
        return count;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
