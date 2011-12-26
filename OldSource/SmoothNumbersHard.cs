using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SmoothNumbersHard {
    public int countSmoothNumbers(int N, int k)
    {
        bool[] memo = new bool[N + 1];
        int i, j;
        for (i = 2; i * i <= N; i++)
        {
            if (!memo[i])
            {
                for (j = i * 2; j <= N; j+= i)
                {
                    memo[j] = true;
                }
            }
        }
        List<int> l = new List<int>();
        for (i = k + 1; i <= N; i++)
        {
            if (!memo[i])
            {
                l.Add(i);
                //Console.WriteLine(i);
            }
        }

        for (i = 0; i <= N; i++) memo[i] = false;
        foreach (int a in l)
        {
            for (j = a; j <= N; j += a)
            {
                memo[j] = true;
            }
        }
        int res = 0;
        for (i = 0; i <= N; i++) if (memo[i]) res++;
        //Console.ReadLine();
        return N -res;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
