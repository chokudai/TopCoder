using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RowsOrdering {
    public int order(string[] rows)
    {
        long mod = 1000000007;
        int i, j;
        int r = rows.Length;
        int c = rows[0].Length;
        long[] need = new long[c];
        for (i = 0; i < c; i++)
        {
            int[] ar = new int[256];
            for (j = 0; j < r; j++)
            {
                ar[(int)rows[j][i]]++;
            }
            Array.Sort(ar);
            Array.Reverse(ar);
            for (j = 0; j < 256; j++)
            {
                need[i] += ar[j] * j;
            }
        }
        long res = 0;
        Array.Sort(need);
        Array.Reverse(need);
        long first = 1;
        for (i = 0; i < c; i++)
        {
            res += need[i] * first;
            res %= mod;
            first *= 50;
            first %= mod;
        }
        res += r;
        res %= mod;

        return (int)res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
