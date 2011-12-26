using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Underprimes {
    public int howMany(int A, int B)
    {
        int i,j;
        int[] memo = new int[100010];
        int[] num = new int[100010];
        for (i = 0; i < 100010; i++)
        {
            memo[i] = i;
            num[i] = 0;
        }
        memo[0] = memo[1] = 100;
        num[1] = num[0] = 100;
        for (i = 2; i < 1000; i++)
        {
            if (num[i] == 0)
            {
                for (j = i; j < 100010; j += i)
                {
                    while (memo[j] % i == 0)
                    {
                        memo[j] /= i;
                        num[j]++;
                    }
                }
            }
        }
        int sum = 0;
        for (i = A; i <= B; i++) if (num[num[i]] == 1) sum++;
        return sum;

    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
