using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SlimeXSlimesCity {
    public int merge(int[] population)
    {
        int i, j, k;
        int len = population.Length;
        int count = 0;
        for (i = 0; i < len; i++)
        {
            long[] array = new long[len];
            for (j = 0; j < len; j++) array[j] = population[j];
            long now = population[i];
            for (j = 0; j < len - 1; j++)
            {
                Array.Sort(array);
                for (k = len - 1; k >= j; k--)
                {
                    if (array[k] == now) break;
                }
                if (k == j) break;
                now += array[j];
                array[k] = now;
                array[j] = 0;
            }
            if (j == len - 1) count++;
        }
        return count;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
