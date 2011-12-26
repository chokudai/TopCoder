using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SequenceSums {
    public int[] sequence(int N, int L)
    {
        int i, j;
        int[] res = new int[1];
        for (i = L; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                if ((N * 2) % i != 0 || N % i == 0) continue;
                res = new int[i];bool flag = false;
                for (j = 0; j < i; j++)
                {
                    res[j] = (((N * 2) / i) - ((i - 1) - j * 2))/2;
                    if (res[j] < 0) flag = true;
                }
                if (flag) continue;
                break;
            }
            else
            {
                if (N % i != 0) continue;
                res = new int[i]; bool flag = false;
                for (j = 0; j < i; j++)
                {
                    res[j] = ((N) / i) - ((i - 1) / 2) + j;
                    if (res[j] < 0) flag = true;
                }
                if (flag) continue;
                break;
            }
        }
        if (i == 101) return new int[] { };
        return res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
