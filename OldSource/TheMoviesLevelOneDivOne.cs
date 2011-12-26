using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheMoviesLevelOneDivOne {
    public long find(int n, int m, int[] row, int[] seat)
    {
        long[] ar = new long[row.Length];
        long a = 1000000009;
        long res = (long)n * (m-1);
        int i;
        for (i = 0; i < row.Length; i++)
        {
            ar[i] = (row[i] - 1) * a + (seat[i] - 1);
        }
        Array.Sort(ar);
        for (i = 0; i < row.Length; i++)
        {
            res -= 2;
            if (ar[i] % a == 0 || (i != 0 && ar[i - 1] == ar[i] - 1)) res++;
            if (ar[i] % a == m-1) res++;
        }
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
