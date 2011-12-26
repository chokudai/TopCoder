using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PerfectPermutation {
    public int reorder(int[] P)
    {
        int len = P.Length;
        int[] Q = new int[len];
        int i;
        if (len == 0) return 0;
        int res = 0;
        bool[] flag = new bool[len];
        for (i = 0; i < len; i++)
        {
            if (flag[i]) continue;
            res++;
            int j = i;
            do
            {
                flag[j] = true;
                j = P[j];
            } while (!flag[j]);
        }
        if (res == 1) res = 0;
        return res;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
