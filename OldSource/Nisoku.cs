using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Nisoku {
    public double theMax(double[] cards)
    {
        int i,j;
        int len = cards.Length;
        Array.Sort(cards);
        double best = 0;
        for (i = 0; i <= len; i += 2)
        {
            double sum = 0;
            for (j = 0; j < len; j++)
            {
                if (j < i && j >= i / 2) continue;
                double now = 0;
                if (j >= i)
                {
                    now = cards[j];
                }
                else
                {
                    now = cards[j] + cards[i - j - 1];
                }
                if (sum == 0) sum = now;
                else sum = Math.Max(sum + now, sum * now);
            }
            best = Math.Max(best, sum);
        }
        return best;
    }




}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
