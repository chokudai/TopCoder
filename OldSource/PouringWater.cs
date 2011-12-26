using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PouringWater {
    public int getMinBottles(int N, int K)
    {
        int i;
        int firstN = N;
        while (true)
        {
            int now = 0;
            int p = 0;
            int memo = 0;
            //Console.WriteLine(N);
            for (i = 25; i >= 0; i--)
            {
                if ((N & (1 <<i )) != 0)
                {
                    if (p != K)
                    {
                        now += (1 << i);
                        p++;
                        if (p == K) memo = i;
                        //Console.WriteLine(i);
                    }
                    else
                    {
                        now += (1 << memo);
                        N = now;
                        break;
                    }
                }
            }
            if (i < 0)
            {
                //Console.Write(now);
                return now-firstN;
            }
        }
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
