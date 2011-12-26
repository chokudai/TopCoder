using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FactoVisors {
    public int getNum(int[] divisors, int[] multiples)
    {
        Array.Sort(multiples);
        Array.Reverse(multiples);
        int i, j, k;
        int MAX = 1000000;
        int count = 0;
        for (i = 1; i < MAX; i++)
        {
            bool flag = false;
            for (j = 0; j < divisors.Length; j++) if (i % divisors[j] != 0) { flag = true; break; }
            if (flag) continue;
            for (j = 0; j < multiples.Length; j++) if (multiples[j] % i != 0) { flag = true; break; }
            if (flag) continue;
            count++;
        }
        for (k = 1; multiples[0] / k >= MAX; k++)
        {
            if (multiples[0] % k != 0) continue;
            i = multiples[0] / k;
            bool flag = false;
            for (j = 0; j < divisors.Length; j++) if (i % divisors[j] != 0) { flag = true; break; }
            if (flag) continue;
            for (j = 0; j < multiples.Length; j++) if (multiples[j] % i != 0) { flag = true; break; }
            if (flag) continue;
            count++;
        }
        return count;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
