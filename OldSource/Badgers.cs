using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Badgers {
    public int feedMost(int[] hunger, int[] greed, int totalFood)
    {
        int N = hunger.Length;
        int i,j;
        for (i = 0; i <= N; i++)
        {
            int[] ar = new int[N];
            for (j = 0; j < N; j++)
            {
                ar[j] = hunger[j] + greed[j] * (i-1);
            }
            Array.Sort(ar);
            int nokori = totalFood;
            for (j = 0; j < i; j++)
            {
                nokori -= ar[j];
                if (nokori < 0) break;
            }
            if (j < i) break;
            //Console.WriteLine(nokori);
        }
        return i - 1;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
