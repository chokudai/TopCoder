using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Filtering {
    public int[] designFilter(int[] sizes, string outcome)
    {
        int len = sizes.Length;
        int i;
        int amax = -1;
        int amin = 99999999;
        for (i = 0; i < len; i++)
        {
            if (outcome[i] == 'A')
            {
                amax = Math.Max(sizes[i], amax);
                amin = Math.Min(sizes[i], amin);
            }
        }
        for (i = 0; i < len; i++)
        {
            if (outcome[i] == 'R')
            {
                if (sizes[i] <= amax && sizes[i] >= amin)
                {
                    return new int[0];
                }
            }
        }
        return new int[2] { amin, amax };
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
