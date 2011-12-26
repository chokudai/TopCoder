using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SortingWithPermutation {
public int[] getPermutation(int[] a) {
    int i, j;
    int len = a.Length;
    int[] memo = new int[len];
    for (i = 0; i < len; i++)
    {
        memo[i] = -1;
    }
    for (i = 0; i < len; i++)
    {
        int min = int.MaxValue;
        int num = -1;
        for (j = 0; j < len; j++)
        {
            if (memo[j] != -1) continue;
            if (min > a[j])
            {
                num = j;
                min = a[j];
            }
        }
        memo[num] = i;
    }
    return memo;
}




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
