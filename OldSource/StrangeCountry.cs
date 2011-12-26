using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class StrangeCountry {


    public int transform(string[] g)
    {
        int len = g.Length;
        int[] data = new int[len];
        int i, j,k;
        for (i = 0; i < len; i++)
        {
            data[i] = i;
        }
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                if (g[i][j] == 'Y' && data[i]!=data[j])
                {
                    int c = data[j];
                    for (k = 0; k < len; k++) if (data[k] == c) data[k] = data[i];
                }
            }
        }
        int[] sumpoint = new int[len];
        int[] sumroad = new int[len];
        int road = 0;
        for (i = 0; i < len; i++)
        {
            sumpoint[data[i]]++;
            for (j = 0; j < len; j++)
            {
                if (g[i][j] == 'Y') { sumroad[data[i]]++; road++; }
            }
        }
        int res = 0;
        if (road / 2 < len - 1) return -1;
        for (i = 0; i < len; i++)
        {
            if (sumpoint[i] != 0)
            {
                res++;
                if (sumroad[i] == 0) return -1;
            }
        }
        return res-1;
    }


}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
